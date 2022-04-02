using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
	[SerializeField] private GameObject item;
	public bool spawning = true;

	private float spawnDistance = 1f;
	public float spawnSpeed = 12f;

	public IEnumerator SpawnItem()
	{
		if(spawning == true)
		{
			Vector3 pos = Random.onUnitSphere * spawnDistance;
			Instantiate(item, pos, Quaternion.identity);

			yield return new WaitForSeconds(spawnSpeed);

			StartCoroutine(SpawnItem());
		}
		else if(spawning == false)
		{
			StopCoroutine(SpawnItem());
		}
	}
}
