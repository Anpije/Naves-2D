using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 6f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}