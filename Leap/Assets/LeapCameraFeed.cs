using UnityEngine;
using UnityEngine.UI;
using Leap;                // LeapImageRetriever は namespace Leap

public class LeapCameraFeed : MonoBehaviour
{
    [Header("必須 : Leap Image Retriever")]
    public LeapImageRetriever imageRetriever;

    [Header("2D 表示 (RawImage) – 任意")]
    public RawImage targetUI;

    [Header("3D 表示 (Renderer) – 任意")]
    public Renderer targetRenderer;

    void Update()
    {
        if (!imageRetriever) return;

        // 最新の IR 画像（左右スタック 640×960 など）
        Texture2D tex = imageRetriever.TextureData.TextureData.CombinedTexture;

        if (tex != null)
        {
            if (targetUI)       targetUI.texture                    = tex;
            if (targetRenderer) targetRenderer.material.mainTexture = tex;
        }
    }
}
