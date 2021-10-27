using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;
    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerRange = 5.0f;
    private float ySpawn = 0;

    private float powerSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int ramdomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);
        Instantiate(enemies[ramdomIndex], spawnPos, enemies[ramdomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerRange, zPowerRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);

    }
}
