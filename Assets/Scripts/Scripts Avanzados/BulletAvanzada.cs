using UnityEngine;

public class BulletAvanzada : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 3f;
    public TrailRenderer trail;


    void Start()
    {
        Destroy(gameObject, lifetime);

        if (AudioManager.instance != null)
            AudioManager.instance.PlayShootSound();
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (GameVFX.instance != null)
                GameVFX.instance.PlayExplosion(other.transform.position);
           
            if (AudioManager.instance != null)
                AudioManager.instance.PlayExplosionSound();

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}