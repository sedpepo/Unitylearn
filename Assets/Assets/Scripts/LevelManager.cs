using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public GameObject enemyToSpawn;

    private float actualSpawnRadius;
    private float actualSpawnAngle;

    public float enemySpawnFrequency = 1f;
    public float spawnTimer = 0f;
    private Vector3 enemySpawnPosition;
    
    public float maxSpawnRadius;
    public float minSpawnRadius;
    
    private GameObject spawnedEnemy;
    private int score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score>100)
        {
            enemySpawnFrequency = 0.2f;
        }
    }
    private void FixedUpdate()
    {
        spawnTimer = spawnTimer + 0.02f;
        if (spawnTimer >= enemySpawnFrequency)
        {
            spawnTimer = 0;
            spawnEnemy();

        }
        
    }
    void spawnEnemy()
    {
        actualSpawnRadius = Random.Range(maxSpawnRadius, minSpawnRadius);
        actualSpawnAngle = Random.Range(0, 360);

        enemySpawnPosition = new Vector3(actualSpawnRadius * Mathf.Cos(actualSpawnAngle), 0f, actualSpawnRadius * Mathf.Sin(actualSpawnAngle));

        spawnedEnemy = Instantiate(enemyToSpawn, enemySpawnPosition, Quaternion.identity);
        spawnedEnemy.GetComponent<EnemyBase>().enemyTarget = Player;

    }
}
