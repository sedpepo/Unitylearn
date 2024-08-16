using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyToSpawn;
    public float enemySpawnFrequwncy = 1f;
    public float spawnTimer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        spawnTimer = spawnTimer + 0.02f;
        if (spawnTimer >= enemySpawnFrequwncy)
        {
            spawnEnemy();
        }
        
    }
    void spawnEnemy()
    {

    }
}
