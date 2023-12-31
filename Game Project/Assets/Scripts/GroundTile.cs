using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour { 
    GroundSpawner groundSpawner;

    // Start is called before the first frame update
    private void Start()
    {
     groundSpawner  = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle () 
        // Choose random point
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
 }     // Spawn the obstacle
