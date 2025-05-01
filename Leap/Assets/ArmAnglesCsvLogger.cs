/******************************************************************************
 * ArmAnglesCsvLogger.cs                                                      *
 *                                                                            *
 *  ◆ 機能                                                                    *
 *   ◇ Leap Motion から肩・肘 4 関節角を毎フレーム算出                        *
 *   ◇ L/R 個別 Offset / Scale / Limit / SignFlip / Invert                    *
 *   ◇ Space / UI ボタンで CSV+Java 同時録画開始・停止                       *
 *   ◇ C キーで “腕を真下” を 0° キャリブ                                     *
 *   ◇ UI Text に現在角度をリアルタイム表示                                   *
 *                                                                            *
 *  ※ 動画機能（VideoRecorderController）は完全に削除済み                     *
 ******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Leap;
using Leap.Unity;
using System.IO;
using System.Text;

[RequireComponent(typeof(SotaJavaExporter))]
public class ArmAnglesCsvLogger : MonoBehaviour
{
    /* ───────── Provider & UI ───────── */
    [Header("Leap XR Service Provider")]
    public LeapProvider provider;

    [Header("UI")]
    public Button          logButton;
    public Text            buttonLabel;
    public TMP_InputField  fileNameInput;
    public Text            shoulderLText;
    public Text            elbowLText;
    public Text            shoulderRText;
    public Text            elbowRText;

    [Header("Optional HMD / MainCamera")]
    public Transform headTransform;

    /* ───────── Offset (deg) ───────── */
    [Header("Offset (deg)")]
    public float shoulderOffsetDegR = 0f;
    public float shoulderOffsetDegL = 0f;
    public float elbowOffsetDegR    = 0f;
    public float elbowOffsetDegL    = 0f;

    /* ───────── Scale (×) ───────── */
    [Header("Scale Coefficient (×)")]
    public float shoulderScale = 1f;
    public float elbowScale    = 1f;

    /* ───────── Shoulder Limit ───────── */
    [Header("Shoulder Limit ON/OFF")]
    public bool  limitShoulder = true;
    [Header("Shoulder Limit (Right)")]
    public float shoulderMinR  = -30f;
    public float shoulderMaxR  =  90f;
    [Header("Shoulder Limit (Left)")]
    public float shoulderMinL  = -30f;
    public float shoulderMaxL  =  90f;

    /* ───────── Elbow Limit ───────── */
    [Header("Elbow Limit ON/OFF")]
    public bool  limitElbow = true;
    [Header("Elbow Limit (Right)")]
    public float elbowMinR  = 0f;
    public float elbowMaxR  = 90f;
    [Header("Elbow Limit (Left)")]
    public float elbowMinL  = 0f;
    public float elbowMaxL  = 90f;

    /* ───────── Sign Flip ───────── */
    [Header("Sign Flip (±1)")]
    public int shoulderRSign = -1;   // 右肩
    public int shoulderLSign = -1;   // 左肩
    public int elbowRSign    =  1;   // 右肘
    public int elbowLSign    = -1;   // 左肘

    /* ───────── Elbow Curve Invert ───────── */
    [Header("Elbow Mapping 0-90° (Invert per side)")]
    public bool invertElbowCurveR = false;
    public bool invertElbowCurveL = false;

    /* ───────── Java Export ───────── */
    [Header("Java Export")]
    public bool  exportJava   = true;
    public string javaFileName = "poseSeq";

    /* ───────── Public Angles ───────── */
    public float ShoulderL { get; private set; }
    public float ShoulderR { get; private set; }
    public float ElbowL    { get; private set; }
    public float ElbowR    { get; private set; }

    /* ───────── Const ───────── */
    const float W = 0.30f;   // 肩幅 (m)
    const float H = -0.15f;  // 肩高さ (m)
    const float D = 0.10f;   // 肩前後 (m)

    /* ───────── Internal ───────── */
    StreamWriter       writer;
    readonly StringBuilder sb = new(128);
    bool   isLogging;
    int    rows;
    float  csvTimer;
    Vector3 calibDown = Vector3.down;

    SotaJavaExporter javaExp;

    /* ══════════════════════════════ INITIALIZE ═════════════════════════════ */
    void Awake()
    {
        if (logButton)   logButton.onClick.AddListener(ToggleLogging);
        if (buttonLabel) buttonLabel.text = "計測開始";
        javaExp = GetComponent<SotaJavaExporter>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ToggleLogging();

        if (Input.GetKeyDown(KeyCode.C))
        {
            calibDown = headTransform ? -headTransform.up : Vector3.down;
            Debug.Log("[ArmLogger] Calibrated 0°");
        }
    }

    /* ═════════════════════ CSV & Java CONTROL ═════════════════════════════ */
    void ToggleLogging() { if (isLogging) StopLogging(); else StartLogging(); }

    void StartLogging()
    {
        string stem = string.IsNullOrWhiteSpace(fileNameInput.text) ? "arm_angles"
                    : Sanitize(fileNameInput.text.Trim());

        string csvPath = Path.Combine(Application.persistentDataPath, stem + ".csv");
        writer = new StreamWriter(csvPath, false, Encoding.UTF8);
        writer.WriteLine("# time(ms),shoulderL,elbowL,shoulderR,elbowR");

        if (exportJava) javaExp.StartFile(stem);

        isLogging   = true;
        rows        = 0;
        csvTimer    = 0;
        buttonLabel.text = "計測中";
        Debug.Log($"[ArmLogger] ▶︎ CSV {csvPath}");
    }

    void StopLogging()
    {
        writer?.Close();
        writer = null;

        if (exportJava) javaExp.CloseFile();

        isLogging = false;
        buttonLabel.text = "計測開始";
    }

    /* ═════════════════════ MAIN LOOP ═════════════════════════════════════ */
    void LateUpdate()
    {
        if (provider == null) return;

        Vector3 fwd   = headTransform ? headTransform.forward : Vector3.forward;
        Vector3 right = headTransform ? headTransform.right   : Vector3.right;
        Vector3 chest = headTransform
                      ? headTransform.position + fwd * D + Vector3.up * H
                      : new Vector3(0f, H, D);
        Vector3 S_R = chest + right * (W * 0.5f);
        Vector3 S_L = chest - right * (W * 0.5f);

        foreach (Hand hand in provider.CurrentFrame.Hands)
        {
            bool   L  = hand.IsLeft;
            Vector3 sh = L ? S_L : S_R;
            Vector3 el = hand.Arm.ElbowPosition;
            Vector3 wr = hand.WristPosition;

            Vector3 upper = (el - sh).normalized;
            Vector3 fore  = (wr - el).normalized;

            /* ─ Shoulder ─ */
            Vector3 axis   = L ? right : -right;
            float   rawP   = Vector3.SignedAngle(calibDown, upper, axis);
            float   pitch  = (rawP * (L ? shoulderLSign : shoulderRSign)
                              + (L ? shoulderOffsetDegL : shoulderOffsetDegR))
                              * shoulderScale;

            if (limitShoulder)
            {
                float min = L ? shoulderMinL : shoulderMinR;
                float max = L ? shoulderMaxL : shoulderMaxR;
                pitch = Mathf.Clamp(pitch, min, max);
            }

            /* ─ Elbow 0-90 ─ */
            float rawA = Mathf.Clamp(Vector3.Angle(upper, fore), 0f, 180f);
            float flex = Mathf.InverseLerp(0f, 135f, rawA) * 90f;
            if (L ? invertElbowCurveL : invertElbowCurveR) flex = 90f - flex;

            float elbow = (flex * (L ? elbowLSign : elbowRSign)
                           + (L ? elbowOffsetDegL : elbowOffsetDegR))
                           * elbowScale;

            if (limitElbow)
            {
                float min = L ? elbowMinL : elbowMinR;
                float max = L ? elbowMaxL : elbowMaxR;
                elbow = Mathf.Clamp(elbow, min, max);
            }

            if (L) { ShoulderL = pitch; ElbowL = elbow; }
            else   { ShoulderR = pitch; ElbowR = elbow; }
        }

        /* ─ UI 更新 ─ */
        shoulderLText.text = $"{ShoulderL:F1}°";
        elbowLText.text    = $"{ElbowL:F1}°";
        shoulderRText.text = $"{ShoulderR:F1}°";
        elbowRText.text    = $"{ElbowR:F1}°";

        /* ─ CSV & Java 出力 ─ */
        if (isLogging)
        {
            long t = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            sb.Append(t).Append(',')
              .AppendFormat("{0:F1},{1:F1},{2:F1},{3:F1}\n",
                             ShoulderL, ElbowL, ShoulderR, ElbowR);
            writer.Write(sb.ToString());
            sb.Clear();
            rows++;

            if (exportJava)
                javaExp.AddPose(ShoulderL, ElbowL, ShoulderR, ElbowR);

            csvTimer += Time.deltaTime;
            if (csvTimer >= 1f)
            {
                Debug.Log($"rows={rows}  L[s:{ShoulderL:F1} e:{ElbowL:F1}]  " +
                          $"R[s:{ShoulderR:F1} e:{ElbowR:F1}]");
                csvTimer = 0f;
            }
        }
    }

    void OnDestroy() { if (isLogging) StopLogging(); }

    /* ═════════════════════ UTIL ════════════════════════════════════════ */
    static string Sanitize(string s)
    {
        foreach (char c in Path.GetInvalidFileNameChars())
            s = s.Replace(c.ToString(), "");
        return string.IsNullOrEmpty(s) ? "arm_angles" : s;
    }
}
