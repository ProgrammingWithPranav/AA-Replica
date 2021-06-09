using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject pinPrefab;

	private void Update()
	{

		if(Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1"))
		{
			SpawnPin();
		}
	}

	private void SpawnPin()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}
}
