using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
	[SerializeField] private GameObject log;
	public bool spawning = true;

	private float spawnDistance = 1f;
	public float spawnSpeed = 12f;

	// spawns a log at a random spot around a sphere.
	// spawn speed is adjusted at Score script.
	public IEnumerator SpawnLog()
	{
		if(spawning == true)
		{
			Vector3 pos = Random.onUnitSphere * spawnDistance;
			Instantiate(log, pos, Quaternion.identity);

			yield return new WaitForSeconds(spawnSpeed);

			StartCoroutine(SpawnLog());
		}
		else if(spawning == false)
		{
			StopCoroutine(SpawnLog());
		}
	}
}
