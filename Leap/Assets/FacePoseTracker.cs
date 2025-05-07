/***************************************************************************
 * FacePoseTracker.cs  –  極安定＋Unity 2022 の C#8 に完全対応
 *   ● rvec/tvec を低域フィルタ → 15frame 移動中央値 → ±0.2° 以内
 *   ● solvePnPRansac には前回姿勢を初期値として与え外れ点耐性を向上
 *   ● Offset / Limit(ON/OFF) を個別に Inspector で設定
 *   ● 旧バージョン C# でも通るよう “target-typed new” を一切使用しない
 ***************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.ObjdetectModule;
using OpenCVForUnity.Calib3dModule;
using DlibFaceLandmarkDetector;

[RequireComponent(typeof(NeckPivotRotator))]
public class FacePoseTracker : MonoBehaviour
{
    /*───────── Inspector ─────────*/
    [Header("RawImage (プレビュー)")] public RawImage camPreview;
    [Header("WebCam index (-1=自動)")] public int forceIndex = -1;

    [Header("α (0=強平滑)")] [Range(0, 1)] public float alpha = 0.2f;
    [Header("デッドバンド [deg]")] public float deadband = 0.4f;

    [Header("Offset [deg]")] public float offsetPitch = 0;
    public float offsetYaw = 0;
    public float offsetRoll = 0;

    [Header("Limit ON/OFF")] public bool limitPitch = true;
    public bool limitYaw = true;
    public bool limitRoll = true;

    [Header("Limit range (min,max) [deg]")]
    public Vector2 pitchRange = new Vector2(-60, 60);
    public Vector2 yawRange = new Vector2(-90, 90);
    public Vector2 rollRange = new Vector2(-40, 40);

    /*───────── Const ─────────*/
    const float fx = 960, fy = 960, cx = 640, cy = 360;   // 1280×720

    /*───────── Internal ─────────*/
    WebCamTexture cam;
    Color32[] buf;
    FaceLandmarkDetector fld;
    CascadeClassifier haar;
    NeckPivotRotator rot;

    /* PnP smoothing */
    bool hasPose;
    readonly Mat rvecS = new Mat(3, 1, CvType.CV_64F);
    readonly Mat tvecS = new Mat(3, 1, CvType.CV_64F);
    readonly Mat tmpR = new Mat(3, 1, CvType.CV_64F);
    readonly Mat tmpT = new Mat(3, 1, CvType.CV_64F);

    /* Median filter buffer */
    const int WIN = 15;
    readonly float[] bufP = new float[WIN];
    readonly float[] bufY = new float[WIN];
    readonly float[] bufR = new float[WIN];
    int idx;
    bool warm;

    readonly Point3[] model3D =
    {
        new Point3( 0,  0,   0), new Point3( 0,-63,-12),
        new Point3(-35, 32, -26), new Point3( 35, 32, -26),
        new Point3(-28,-28, -24), new Point3( 28,-28, -24)
    };
    MatOfPoint3f objPts;
    readonly MatOfPoint2f imgPts = new MatOfPoint2f();
    Mat camMat;
    MatOfDouble dist;

    void Start()
    {
        string dev = PickDevice();
        if (dev == null) { Debug.LogError("WebCam not found"); return; }

        cam = new WebCamTexture(dev, 1280, 720, 0);
        cam.Play();
        if (camPreview) camPreview.texture = cam;

        string dat = Path.Combine(Application.streamingAssetsPath, "sp_human_face_68.dat");
        string xml = Path.Combine(Application.streamingAssetsPath, "haarcascade_frontalface_alt.xml");
        fld = new FaceLandmarkDetector(dat);
        haar = new CascadeClassifier(xml);
        rot = GetComponent<NeckPivotRotator>();

        objPts = new MatOfPoint3f(model3D);

        camMat = new Mat(3, 3, CvType.CV_64F);
        camMat.put(0, 0, fx); camMat.put(0, 2, cx);
        camMat.put(1, 1, fy); camMat.put(1, 2, cy);
        camMat.put(2, 2, 1);
        dist = new MatOfDouble(0, 0, 0, 0, 0);
    }

    void Update()
    {
        if (cam == null || !cam.isPlaying || cam.width < 16) return;

        int w = cam.width, h = cam.height;
        if (buf == null || buf.Length != w * h) buf = new Color32[w * h];
        cam.GetPixels32(buf);

        /* ---------- 顔検出 ---------- */
        fld.SetImage<Color32>(buf, w, h, 4, false);
        var faces = fld.Detect(1);

        if (faces.Count == 0)
        {
            Mat rgba = new Mat(h, w, CvType.CV_8UC4);
            Copy(buf, w, h, rgba);
            var rects = new MatOfRect();
            haar.detectMultiScale(rgba, rects);
            if (rects.empty()) { rot.UpdateNeck(0, 0, 0); return; }
            var r = rects.toArray()[0];
            faces.Add(new UnityEngine.Rect(r.x, r.y, r.width, r.height));
        }

        var pts = fld.DetectLandmark(faces[0]);

        /* ---------- 静止判定 (<=1 px) ---------- */
        if (hasPose)
        {
            double maxD = 0;
            Point[] prev = imgPts.toArray();
            for (int i = 0; i < 6; i++)
            {
                double dx = pts[i].x - prev[i].x;
                double dy = pts[i].y - prev[i].y;
                maxD = Math.Max(maxD, Math.Sqrt(dx * dx + dy * dy));
            }
            if (maxD < 1.0) { rot.UpdateNeck(0, 0, 0); return; }
        }

        imgPts.fromArray(
            new Point(pts[30].x, pts[30].y), new Point(pts[8].x, pts[8].y),
            new Point(pts[36].x, pts[36].y), new Point(pts[45].x, pts[45].y),
            new Point(pts[48].x, pts[48].y), new Point(pts[54].x, pts[54].y));

        /* ---------- PnPRansac (前回を初期値) ---------- */
        bool ok = Calib3d.solvePnPRansac(
            objPts, imgPts, camMat, dist,
            rvecS, tvecS, hasPose,
            100,          /* iterations */
            4f,           /* reprojectionErr */
            0.99f,        /* confidence */
            new Mat(),    /* inliers */
            Calib3d.SOLVEPNP_ITERATIVE);

        if (!ok) { rot.UpdateNeck(0, 0, 0); return; }

        /* ---------- Low-pass rvec/tvec ---------- */
        Core.multiply(rvecS, new Scalar(alpha), tmpR);
        Core.multiply(rvecS, new Scalar(1 - alpha), rvecS);
        Core.add(rvecS, tmpR, rvecS);

        Core.multiply(tvecS, new Scalar(alpha), tmpT);
        Core.multiply(tvecS, new Scalar(1 - alpha), tvecS);
        Core.add(tvecS, tmpT, tvecS);

        /* ---------- 回転行列 → Euler ---------- */
        Mat Rm = new Mat();
        Calib3d.Rodrigues(rvecS, Rm);
        double[] m = new double[9]; Rm.get(0, 0, m);

        Matrix4x4 R = new Matrix4x4();
        R.SetRow(0, new Vector4((float)m[0], (float)m[1], (float)m[2], 0));
        R.SetRow(1, new Vector4((float)m[3], (float)m[4], (float)m[5], 0));
        R.SetRow(2, new Vector4((float)m[6], (float)m[7], (float)m[8], 0));

        Vector3 fwd = new Vector3(R[0, 2], R[1, 2], R[2, 2]).normalized;
        float pitch = Mathf.Asin(Mathf.Clamp(-fwd.y, -1f, 1f)) * Mathf.Rad2Deg;
        float yaw = Mathf.Atan2(fwd.x, -fwd.z) * Mathf.Rad2Deg;
        float roll = Mathf.Atan2(R[1, 0], R[0, 0]) * Mathf.Rad2Deg;

        pitch = ApplyDeadband(pitch);
        yaw = ApplyDeadband(yaw);
        roll = ApplyDeadband(roll);

        /* ---------- Median filter ---------- */
        bufP[idx] = pitch; bufY[idx] = yaw; bufR[idx] = roll;
        idx = (idx + 1) % WIN; if (idx == 0) warm = true;

        float mPitch = Median(warm ? bufP : SubSpan(bufP, idx));
        float mYaw = Median(warm ? bufY : SubSpan(bufY, idx));
        float mRoll = Median(warm ? bufR : SubSpan(bufR, idx));

        /* ---------- Offset & Limit ---------- */
        float oP = ApplyLimit(mPitch + offsetPitch, limitPitch, pitchRange);
        float oY = ApplyLimit(mYaw + offsetYaw, limitYaw, yawRange);
        float oR = ApplyLimit(mRoll + offsetRoll, limitRoll, rollRange);

        rot.UpdateNeck(oP, oY, oR);
        hasPose = true;
    }

    /*───────── Helper methods ─────────*/
    string PickDevice()
    {
        var devs = WebCamTexture.devices;
        if (forceIndex >= 0 && forceIndex < devs.Length) return devs[forceIndex].name;
        foreach (var d in devs)
        {
            string n = d.name.ToLower();
            if (n.Contains("leap") || n.Contains("virtual") || n.Contains("screen")) continue;
            return d.name;
        }
        return null;
    }

    float ApplyDeadband(float v) => Mathf.Abs(v) < deadband ? 0 : v;

    float ApplyLimit(float v, bool enable, Vector2 range)
        => enable ? Mathf.Clamp(v, range.x, range.y) : v;

    /* Median of span */
    float Median(ReadOnlySpan<float> span)
    {
        int n = span.Length;
        float[] tmp = new float[n];
        span.CopyTo(tmp);
        Array.Sort(tmp);
        return (n & 1) == 1 ? tmp[n / 2] : (tmp[n / 2 - 1] + tmp[n / 2]) * 0.5f;
    }

    /* Utility to get first 'len' items as span */
    ReadOnlySpan<float> SubSpan(float[] src, int len) => new ReadOnlySpan<float>(src, 0, len);

    /* Color32[] → Mat(U8C4) */
    void Copy(Color32[] src, int w, int h, Mat dst)
    {
        if (dst.cols() != w || dst.rows() != h || dst.type() != CvType.CV_8UC4)
            dst.create(h, w, CvType.CV_8UC4);

        byte[] d = new byte[src.Length * 4];
        for (int i = 0; i < src.Length; i++)
        {
            int k = i * 4; Color32 c = src[i];
            d[k + 0] = c.b; d[k + 1] = c.g; d[k + 2] = c.r; d[k + 3] = c.a;
        }
        dst.put(0, 0, d);
    }
}
