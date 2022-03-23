using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
	[SerializeField] private GameObject ramp;
	public bool spawning = true;

	private float spawnDistance = 1f;

	public IEnumerator SpawnRamp()
	{
		if(spawning == true)
		{
			Vector3 pos = Random.onUnitSphere * spawnDistance;
			Instantiate(ramp, pos, Quaternion.identity);

			yield return new WaitForSeconds(12f);

			StartCoroutine(SpawnRamp());
		}
		else if(spawning == false)
		{
			StopCoroutine(SpawnRamp());
		}
	}
}
