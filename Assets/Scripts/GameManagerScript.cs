using TMPro;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject player;
    [SerializeField] TMP_Text healthText;

    int health = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float xPosition = Random.Range(-8f, 8f);
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(xPosition, 6f), Quaternion.identity);
        //Enlazamos el script del GameManager con el enemigo, para que pueda comunicarle la reducción de vida con su método 'reduceHealth'
        EnemyScript enemyScript = enemy.GetComponent<EnemyScript>();
        enemyScript.gameManagerScript = GetComponent<GameManagerScript>();

    }

    public void reduceHealth(int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            healthText.text = "Game over";
            Destroy(player);
        }
        else { 
            healthText.text = "Health: " + health;
        }

    }
}
