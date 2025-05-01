/******************************************************************************
 * ArmPivotRotator.cs  ―  “符号フリップ式” 汎用バージョン                      *
 *                                                                            *
 *  ▼ 概要                                                                    *
 *   ArmAnglesCsvLogger が毎フレーム公開する角度(°) を Pivot に適用するだけ。    *
 *   ただしモデルの Pivot 軸が左右で向き違いの場合に備え、                      *
 *   各 Pivot ごとに **±1 の符号係数** を Inspector で設定できるようにした。    *
 *                                                                            *
 *      shoulderRSign : 右肩 X 軸まわり (＋1 そのまま / −1 反転)               *
 *      shoulderLSign : 左肩 X 軸まわり                                        *
 *      elbowRSign    : 右肘 Y 軸まわり                                        *
 *      elbowLSign    : 左肘 Y 軸まわり                                        *
 *                                                                            *
 *   デフォルトは “通常的” な向き：                                            *
 *      右肩 +1, 左肩 +1, 右肘 +1, 左肘 −1                                     *
 *                                                                            *
 *  ▼ 使い方                                                                  *
 *   1. このスクリプトを空 GameObject にアタッチ                               *
 *   2. logger に ArmAnglesCsvLogger をドラッグ                                *
 *   3. 4 Pivot Transform を対応スロットに割り当て                             *
 *   4. 軸が逆転している Pivot だけ Sign を −1 に変更                          *
 ******************************************************************************/

using UnityEngine;

public class ArmPivotRotator : MonoBehaviour
{
    [Header("角度ソース (ArmAnglesCsvLogger)")]
    public ArmAnglesCsvLogger logger;

    [Header("右腕 Pivots")]
    public Transform rightShoulderPivot;      // 右肩 Pivot
    public Transform rightElbowPivot;         // 右肘 Pivot

    [Header("左腕 Pivots")]
    public Transform leftShoulderPivot;       // 左肩 Pivot
    public Transform leftElbowPivot;          // 左肘 Pivot

    /* ----- 符号フリップ (Inspector で ±1 を設定) ----- */
    [Header("Sign Flip (±1)")]
    public int shoulderRSign =  1;            // +1:そのまま,  -1:反転
    public int shoulderLSign =  1;
    public int elbowRSign    =  1;
    public int elbowLSign    = -1;            // 左肘は反転するモデルが多い

    /* Bind 回転を保持して “Bind × 追加角度” にする */
    Quaternion rsBind, reBind, lsBind, leBind;

    /* ===================================================================== */
    void Start()
    {
        rsBind = rightShoulderPivot ? rightShoulderPivot.localRotation : Quaternion.identity;
        reBind = rightElbowPivot    ? rightElbowPivot.localRotation    : Quaternion.identity;
        lsBind = leftShoulderPivot  ? leftShoulderPivot.localRotation  : Quaternion.identity;
        leBind = leftElbowPivot     ? leftElbowPivot.localRotation     : Quaternion.identity;
    }

    void LateUpdate()
    {
        if (!logger) return;   // ソース未設定なら何もしない

        /* ───────── 肩 : X 軸回り ───────── */
        if (rightShoulderPivot)
            rightShoulderPivot.localRotation =
                rsBind * Quaternion.AngleAxis(
                            shoulderRSign * logger.ShoulderR, Vector3.right);

        if (leftShoulderPivot)
            leftShoulderPivot.localRotation  =
                lsBind * Quaternion.AngleAxis(
                            shoulderLSign * logger.ShoulderL, Vector3.right);

        /* ───────── 肘 : Y 軸回り ───────── */
        if (rightElbowPivot)
            rightElbowPivot.localRotation    =
                reBind * Quaternion.AngleAxis(
                            elbowRSign * logger.ElbowR, Vector3.up);

        if (leftElbowPivot)
            leftElbowPivot.localRotation     =
                leBind * Quaternion.AngleAxis(
                            elbowLSign * logger.ElbowL, Vector3.up);
    }
}
