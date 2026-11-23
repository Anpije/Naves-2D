using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D rb;
    public GameManagerScript gameManagerScript;
    [SerializeField] float speed = 2.5f;
    [SerializeField] int damage = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = -speed;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("DeadZone"))
        {
            Destroy(gameObject);
            gameManagerScript.reduceHealth(damage);
        }
    }
}
