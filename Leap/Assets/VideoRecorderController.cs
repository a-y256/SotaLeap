using UnityEngine;

#if UNITY_EDITOR
using UnityEditor.Recorder;
using UnityEditor.Recorder.Input;
#endif

public class VideoRecorderController : MonoBehaviour
{
#if UNITY_EDITOR
    /* ───────── Editor 専用実装 ───────── */
    RecorderController         ctrl;
    RecorderControllerSettings ctrlSettings;
    MovieRecorderSettings      movie;

    void Awake()
    {
        /* Controller --------------------------------------------------- */
        ctrlSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        ctrl         = new RecorderController(ctrlSettings);

        /* Movie recorder ------------------------------------------------*/
        movie = ScriptableObject.CreateInstance<MovieRecorderSettings>();
        movie.name               = "ArmCapture";
        movie.Enabled            = true;
        movie.OutputFormat       = MovieRecorderSettings.VideoRecorderOutputFormat.MP4;

        /* ↓ ビットレートはバージョン差異が出るため省略（既定 = High） */
        /*   もし enum が存在する環境ならコメント解除で個別設定できます */
        // movie.VideoBitRateMode = UnityEditor.Recorder.VideoBitrateMode.High;

        movie.ImageInputSettings = new GameViewInputSettings();
        movie.AudioInputSettings.PreserveAudio = false;

        ctrlSettings.AddRecorderSettings(movie);
        ctrlSettings.SetRecordModeToManual();
    }

    public void StartRecording(string stem)
    {
        string path = System.IO.Path.Combine(
            Application.persistentDataPath, stem + ".mp4");

        movie.OutputFile = path;
        ctrl.PrepareRecording();
        ctrl.StartRecording();
        Debug.Log($"[VideoRec] ▶︎ {path}");
    }

    public void StopRecording()
    {
        if (ctrl.IsRecording())
        {
            ctrl.StopRecording();
            Debug.Log("[VideoRec] ■ stopped");
        }
    }
#else
    /* ───────── ビルド後は録画不可 ───────── */
    public void StartRecording(string _) =>
        Debug.LogWarning("Video recording is Editor-only.");
    public void StopRecording() { }
#endif
}
