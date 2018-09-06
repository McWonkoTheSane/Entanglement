using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;

    private float spawnTimer = 1.0f;

    [SerializeField] Vector3[] spawnLocations;

    [SerializeField] private int maxPerTick = 3;

	// Use this for initialization
	void Start ()
    {
        //spawnLocations = new Vector3[10];
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            SpawnObstacles();
        }
	}

    private void SpawnObstacles()
    {
        for(int numObstaclesToSpawn = 0; numObstaclesToSpawn <= maxPerTick; numObstaclesToSpawn++)
        {
            Instantiate(obstacle, spawnLocations[Random.Range(0, spawnLocations.Length - 1)], Quaternion.identity);
        }
      
        spawnTimer = 1.0f;
    }
}
