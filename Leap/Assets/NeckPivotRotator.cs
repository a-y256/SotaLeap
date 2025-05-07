/***************************************************************
 * NeckPivotRotator.cs  – 角度をそのまま 3 軸に適用する汎用版
 ***************************************************************/
using UnityEngine;

public class NeckPivotRotator : MonoBehaviour
{
    [Header("ターゲット Pivot (首)")]
    public Transform neckPivot;       // ← ここにモデルの首ボーンをドラッグ

    [Header("符号フリップ (±1)")]
    public int pitchSign = 1;         // +1 下向きが + /  -1 で反転
    public int yawSign   = 1;         // +1 左向きが + /  -1 で反転
    public int rollSign  = 1;         // +1 左傾きが + /  -1 で反転

    Quaternion bindRot;

    void Start()
    {
        if (!neckPivot) {
            Debug.LogError("[NeckPivotRotator] neckPivot 未設定"); return;
        }
        bindRot = neckPivot.localRotation;       // 初期姿勢を保持
    }

    /// <summary>FacePoseTracker から毎フレーム呼ぶ</summary>
    public void UpdateNeck(float pitchDeg, float yawDeg, float rollDeg)
    {
        if (!neckPivot) return;

        Quaternion q =
            Quaternion.AngleAxis(pitchSign * pitchDeg, Vector3.right) *   // X
            Quaternion.AngleAxis(yawSign   * yawDeg,   Vector3.up)    *   // Y
            Quaternion.AngleAxis(rollSign  * rollDeg,  Vector3.forward);  // Z

        neckPivot.localRotation = bindRot * q;
    }
}
