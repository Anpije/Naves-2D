using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Renderer backgroundRenderer;

    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        backgroundRenderer.material.mainTextureOffset = offset;
    }
}