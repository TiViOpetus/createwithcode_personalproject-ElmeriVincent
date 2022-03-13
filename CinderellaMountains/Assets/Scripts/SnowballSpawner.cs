using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballSpawner : MonoBehaviour
{
	[SerializeField] private GameObject snowball;
	public bool spawning = true;

	private float spawnDistance = 3f;

	void Start ()
	{
		StartCoroutine(SpawnSnowball());
	}

	IEnumerator SpawnSnowball()
	{
		if(spawning == true)
		{
			Vector3 pos = Random.onUnitSphere * spawnDistance;
			Instantiate(snowball, pos, Quaternion.identity);

			yield return new WaitForSeconds(2f);

			StartCoroutine(SpawnSnowball());
		}
		else if(spawning == false)
		{
			StopCoroutine(SpawnSnowball());
		}
	}
}
