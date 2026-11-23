using UnityEngine;

public class CreateStarfield : MonoBehaviour
{
    void Start()
    {
        CreateStarfieldTexture();
    }

    void CreateStarfieldTexture()
    {
        Texture2D texture = new Texture2D(256, 256);

        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color color = Color.black;
                if (Random.Range(0, 100) < 3)
                    color = Color.white;
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();

        GetComponent<Renderer>().material.mainTexture = texture;
    }
}