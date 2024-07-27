using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        // Spawn enemy every 5 seconds
        InvokeRepeating("SpawnEnemy", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void SpawnEnemy()
    {
        //arround the player position but with a minimun range
        Vector2 spawnPosition = new Vector2(transform.position.x + (UnityEngine.Random.Range(5, 10)* (UnityEngine.Random.Range(0,2)*2-1)),
            transform.position.y + (UnityEngine.Random.Range(5, 10) * (UnityEngine.Random.Range(0, 2)*2 -1 )));
        // Instantiate enemy at spawner position
        Instantiate(enemy, spawnPosition, transform.rotation);
        //los enemigos spawnean con un tag de "Enemy"
        enemy.tag = "Enemy";

    }
}
