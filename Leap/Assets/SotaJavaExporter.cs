/******************************************************************************
 * SotaJavaExporter.cs  – 左右肩の Short 係数を公式どおり修正                 *
 ******************************************************************************/

using UnityEngine;
using System.IO;
using System.Text;

public class SotaJavaExporter : MonoBehaviour
{
    const short CONST_POS = 100;   // 1,6,7,8 未使用ジョイント
    const int   PLAY_MS   = 30;   // 各モーション再生時間 [ms]

    StreamWriter jw;
    int poseIndex;

    /* ---------- Java テンプレ ---------- */
    const string HEADER_TOP =
@"//このソースは、VstoneMagicによって自動生成されました。
//ソースの内容を書き換えた場合、VstoneMagicで開けなくなる場合があります。
package jp.co.mysota;
import main.main.GlobalVariable;
import jp.vstone.RobotLib.*;
import jp.vstone.sotatalk.*;
import jp.vstone.sotatalk.SpeechRecog.*;
import java.awt.Color;

public class mymain {

    public CRobotPose pose;

    /* ▼ 自動生成ポーズ配列 (Short[8] × N) */
    Short[][] poses = {
";

    string HEADER_BOTTOM =>
$@"    }};

    public void main() throws SpeechRecogAbortException {{
        if(!GlobalVariable.TRUE) throw new SpeechRecogAbortException(""default"");

        Byte[]  ids   = new Byte[]{{ (byte)1,(byte)2,(byte)3,(byte)4,(byte)5,(byte)6,(byte)7,(byte)8 }};
        Short[] power = new Short[]{{ (short)100,(short)100,(short)100,(short)100,
                                      (short)100,(short)100,(short)100,(short)100 }};

        for(Short[] p : poses) {{
            pose = new CRobotPose();
            pose.SetPose  (ids, p);
            pose.SetTorque(ids, power);
            GlobalVariable.motion.play(pose,{PLAY_MS});
            CRobotUtil.wait({PLAY_MS});
        }}
    }}

    //@<Separate/>
    public mymain() {{
        /*CRobotPose pose*/;
    }}
}}";

    /* ===================================================================== */
    /* public API                                                             */
    /* ===================================================================== */

    /// <summary>録画開始</summary>
    public void StartFile(string fileStem)
    {
        string path = Path.Combine(Application.persistentDataPath, fileStem + ".java");
        jw = new StreamWriter(path, false, Encoding.UTF8);
        jw.Write(HEADER_TOP);
        poseIndex = 0;
        Debug.Log($"[JavaExporter] ▶︎ {path}");
    }

    /// <summary>1 フレームぶんの Short 値を配列行として追記</summary>
    public void AddPose(float shL, float elL, float shR, float elR)
    {
        if (jw == null) return;

        /* --- 指定の式で Short 変換 --- */
        short s1 = CONST_POS;
        short s2 = (short)Mathf.RoundToInt(shL * 10f - 900f);   // 左肩 : θ×10 - 900
        short s3 = (short)Mathf.RoundToInt(elL * 10f);          // 左肘 : θ×10
        short s4 = (short)Mathf.RoundToInt(shR * 10f + 900f);   // 右肩 : θ×10 + 900
        short s5 = (short)Mathf.RoundToInt(elR * 10f);          // 右肘 : θ×10
        short s6 = CONST_POS;
        short s7 = CONST_POS;
        short s8 = CONST_POS;

        jw.WriteLine(
            $"        new Short[]{{{s1},{s2},{s3},{s4},{s5},{s6},{s7},{s8}}},");
        poseIndex++;
    }

    /// <summary>録画終了</summary>
    public void CloseFile()
    {
        if (jw == null) return;

        jw.WriteLine(HEADER_BOTTOM);
        jw.Close();
        jw = null;
        Debug.Log($"[JavaExporter] ■ poses={poseIndex}");
    }
}
