using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
	[SerializeField] private GameObject[] obstacles;
    [SerializeField] private int treeMax = 30;

	private bool spawning = true;
    private float radius = 1;

	void Start ()
	{
		SpawnObstacle(treeMax);
	}

    //Spawns obstacles around a sphere
	void SpawnObstacle(int obstaclesToSpawn)
	{
		if(spawning == true)
		{
            for(int i = 0; i < obstaclesToSpawn; i++)
            {
                Vector3 pos = Random.onUnitSphere * radius;
                int spawnIndex = Random.Range(0, obstacles.Length);
                Instantiate(obstacles[spawnIndex], pos, Quaternion.identity);
            }
		}
		else if(spawning == false)
		{
			spawning = false;
		}
	}
}
