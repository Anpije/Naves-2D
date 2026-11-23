using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    public int scoreValue = 10;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        MoveDown();
        CheckBounds();
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void CheckBounds()
    {
        if (transform.position.y < -6f)
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (gameManager != null)
            {
                gameManager.AddScore(scoreValue);
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}