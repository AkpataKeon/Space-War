using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public GameObject enemyPrefab;   // The enemy prefab to spawn 
    public float spawnInterval = 2f; // Time interval between spawns
    public float spawnXOffset = 10f; // How far off-sceen to the right enemies spawn
    public float moveSpeed = 5f;     // Speed at which enemies move left
    public float minY = -4f;         // minimum y postion for spawning
    public float maxY = 4f;          // maximum y postion for spawning
    
    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        // Track time and spawn enemies at regular intervals
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnEnemy()
  {
    // Random the y postion with a specified range
    float spawnY = Random.Range(minY, maxY);

    // Set the X postion to the right side off-screen
    float spawnX = Camera.main.transform.position.x + spawnXOffset;

    Vector2 spawnPosition = new Vector2(spawnX, spawnY);

    GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);


    Rigidbody2D enemyRb = enemy.GetComponent<Rigidbody2D>();
    if (enemyRb != null)
   {
        enemyRb.velocity = Vector2.left * moveSpeed;
   }
  }
    
}

