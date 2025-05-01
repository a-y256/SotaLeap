/******************************************************************************
 * ArmAnglesCsvLogger.cs – Shoulder / Elbow “全体スケール” 追加版               *
 *                                                                            *
 *  ✔ 角度計算・UI 更新      → 毎フレーム                                   *
 *  ✔ CSV 出力          → ボタン( Space )で ON/OFF                         *
 *  ✔ キャリブ (C)       → 腕を真下に下ろした瞬間を 0° に                  *
 *                                                                            *
 * ─ 新しく追加された Inspector 項目 ──────────────────────────────────────── *
 *    [Scale Coefficient (×)]                                                 *
 *        shoulderScale   … 肩ピッチに掛ける係数 (左右共通, 既定=1)          *
 *        elbowScale      … 肘角に掛ける係数 (左右共通, 既定=1)              *
 *                                                                            *
 *   スケールは  Offset → SignFlip → Scale → Clamp  の順に適用                *
 *                                                                            *
 * その他の Offset / Limit / Invert / Sign Flip 機能はそのまま保持。          *
 ******************************************************************************/

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Leap;
using Leap.Unity;
using System.IO;
using System.Text;

public class ArmAnglesCsvLogger : MonoBehaviour
{
    /* ─ Provider & UI ─ */
    [Header("Leap XR Service Provider")]
    public LeapProvider provider;

    [Header("UI")]
    public Button logButton;
    public Text   buttonLabel;
    public TMP_InputField fileNameInput;
    public Text shoulderLText, elbowLText, shoulderRText, elbowRText;

    [Header("Optional HMD / MainCamera")]
    public Transform headTransform;

    /* ─ Offset (deg) ─ */
    [Header("Offset (deg) ─ Side-specific")]
    public float shoulderOffsetDegR = 0f;
    public float shoulderOffsetDegL = 0f;
    public float elbowOffsetDegR    = 0f;
    public float elbowOffsetDegL    = 0f;

    /* ─ Global Scale (new) ─ */
    [Header("Scale Coefficient (×)")]
    public float shoulderScale = 1f;   // 肩ピッチ用
    public float elbowScale    = 1f;   // 肘角用

    /* ─ Limit ─ */
    [Header("Shoulder Limit")]
    public bool  limitShoulder = true;
    public float shoulderMin   = -30f;
    public float shoulderMax   =  90f;

    [Header("Elbow Limit")]
    public bool  limitElbow = true;
    public float elbowMin   = 0f;
    public float elbowMax   = 90f;

    /* ─ Sign Flip ─ */
    [Header("Sign Flip (±1)")]
    public int shoulderRSign = -1;    // 肩は符号反転済み
    public int shoulderLSign = -1;
    public int elbowRSign    =  1;
    public int elbowLSign    = -1;

    /* ─ Elbow Curve Invert ─ */
    [Header("Elbow Mapping 0-90°  (Invert per side)")]
    public bool invertElbowCurveR = false;
    public bool invertElbowCurveL = false;

    /* ─ Public Angles ─ */
    public float ShoulderL { get; private set; }
    public float ShoulderR { get; private set; }
    public float ElbowL    { get; private set; }
    public float ElbowR    { get; private set; }

    /* 肩位置定数 */
    const float W = 0.30f, H = -0.15f, D = 0.10f;

    /* 内部 */
    StreamWriter writer; readonly StringBuilder sb = new(128);
    bool isLogging; int rows; float csvTimer;
    Vector3 calibDown = Vector3.down;

    /* ══ INIT ══ */
    void Awake()
    {
        if (logButton) logButton.onClick.AddListener(ToggleLogging);
        if (buttonLabel) buttonLabel.text = "計測開始";
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

    /* ══ CSV Control ══ */
    void ToggleLogging() { if (isLogging) StopCsv(); else StartCsv(); }

    void StartCsv()
    {
        string stem = string.IsNullOrWhiteSpace(fileNameInput.text) ? "arm_angles"
                    : Sanitize(fileNameInput.text.Trim());
        string path = Path.Combine(Application.persistentDataPath, stem + ".csv");

        var fs = new FileStream(path,
                                File.Exists(path) ? FileMode.Append : FileMode.Create,
                                FileAccess.Write, FileShare.ReadWrite);
        writer = new StreamWriter(fs, Encoding.UTF8);
        if (fs.Position == 0)
            writer.WriteLine("# time(ms),shoulderL,elbowL,shoulderR,elbowR");

        isLogging = true; rows = 0; csvTimer = 0;
        buttonLabel.text = "計測中";
        Debug.Log($"[ArmLogger] ▶︎ CSV {path}");
    }

    void StopCsv()
    {
        writer?.Close(); writer = null;
        isLogging = false; buttonLabel.text = "計測開始";
    }

    /* ══ Main Loop ══ */
    void LateUpdate()
    {
        if (provider == null) return;

        long t = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Vector3 fwd   = headTransform ? headTransform.forward : Vector3.forward;
        Vector3 right = headTransform ? headTransform.right   : Vector3.right;
        Vector3 chest = headTransform
                      ? headTransform.position + fwd * D + Vector3.up * H
                      : new Vector3(0f, H, D);

        Vector3 S_R = chest + right * (W * .5f);
        Vector3 S_L = chest - right * (W * .5f);

        foreach (Hand hand in provider.CurrentFrame.Hands)
        {
            bool isLeft = hand.IsLeft;
            Vector3 sh  = isLeft ? S_L : S_R;
            Vector3 el  = hand.Arm.ElbowPosition;
            Vector3 wr  = hand.WristPosition;

            Vector3 upper = (el - sh).normalized;
            Vector3 fore  = (wr - el).normalized;

            /* ─ Shoulder ─ */
            Vector3 axis      = isLeft ? right : -right;
            float basePitch   = Vector3.SignedAngle(calibDown, upper, axis);
            int   sSign       = isLeft ? shoulderLSign : shoulderRSign;
            float sOffset     = isLeft ? shoulderOffsetDegL : shoulderOffsetDegR;
            float pitch       = (basePitch * sSign + sOffset) * shoulderScale;
            if (limitShoulder) pitch = Mathf.Clamp(pitch, shoulderMin, shoulderMax);

            /* ─ Elbow 0-90 ─ */
            float rawA        = Mathf.Clamp(Vector3.Angle(upper, fore), 0f, 180f);
            float flex        = Mathf.InverseLerp(0f, 135f, rawA) * 90f;
            bool  inv         = isLeft ? invertElbowCurveL : invertElbowCurveR;
            if (inv) flex = 90f - flex;

            int   eSign       = isLeft ? elbowLSign : elbowRSign;
            float eOffset     = isLeft ? elbowOffsetDegL : elbowOffsetDegR;
            float elbow       = (flex * eSign + eOffset) * elbowScale;
            if (limitElbow) elbow = Mathf.Clamp(elbow, elbowMin, elbowMax);

            if (isLeft) { ShoulderL = pitch; ElbowL = elbow; }
            else        { ShoulderR = pitch; ElbowR = elbow; }
        }

        /* ─ UI ─ */
        shoulderLText.text = $"{ShoulderL:F1}°";
        elbowLText.text    = $"{ElbowL:F1}°";
        shoulderRText.text = $"{ShoulderR:F1}°";
        elbowRText.text    = $"{ElbowR:F1}°";

        /* ─ CSV ─ */
        if (isLogging)
        {
            sb.Append(t).Append(',')
              .AppendFormat("{0:F1},{1:F1},{2:F1},{3:F1}\n",
                            ShoulderL, ElbowL, ShoulderR, ElbowR);
            writer.Write(sb.ToString()); sb.Clear(); rows++;

            csvTimer += Time.deltaTime;
            if (csvTimer >= 1f)
            {
                Debug.Log($"rows={rows}  L[s:{ShoulderL:F1} e:{ElbowL:F1}]  " +
                          $"R[s:{ShoulderR:F1} e:{ElbowR:F1}]");
                csvTimer = 0f;
            }
        }
    }

    void OnDestroy() { if (isLogging) StopCsv(); }

    static string Sanitize(string s)
    {
        foreach (char c in Path.GetInvalidFileNameChars())
            s = s.Replace(c.ToString(), "");
        return string.IsNullOrEmpty(s) ? "arm_angles" : s;
    }
}
