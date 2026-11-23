using UnityEngine;

public class GameVFX : MonoBehaviour
{
    public static GameVFX instance;

    public GameObject explosionPrefab;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayExplosion(Vector3 position)
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
            Destroy(explosion, 2f);
        }
    }
}