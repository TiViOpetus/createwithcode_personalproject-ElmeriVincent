using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefabs;
	public float distance = 100f;

	void Start ()
	{
		StartCoroutine(SpawnObject());
	}

	IEnumerator SpawnObject()
	{
		Vector3 pos = Random.onUnitSphere * 100f;
		Instantiate(prefabs, pos, Quaternion.identity);

		yield return new WaitForSeconds(5f);

		StartCoroutine(SpawnObject());
	}
}
