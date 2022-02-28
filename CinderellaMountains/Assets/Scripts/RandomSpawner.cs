using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
	public GameObject snowball;
	public float distance = 20f;

	void Start ()
	{
		StartCoroutine(SpawnSnowball());
	}

	IEnumerator SpawnSnowball()
	{
		Vector3 pos = Random.onUnitSphere * 20f;
		Instantiate(snowball, pos, Quaternion.identity);

		yield return new WaitForSeconds(1f);

		StartCoroutine(SpawnSnowball());
	}
}
