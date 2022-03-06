using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
	public GameObject snowball;
	[SerializeField] private float distance = 100f;

	public bool spawning = true;

	void Start ()
	{
		StartCoroutine(SpawnSnowball());
	}

	IEnumerator SpawnSnowball()
	{
		if(spawning == true)
		{
			Vector3 pos = Random.onUnitSphere * 20f;
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
