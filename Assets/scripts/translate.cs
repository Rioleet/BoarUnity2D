using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour {
	public GameObject[] spawnPrefab;
	public int SpeedBorovs = 15;

	float randY;
	Vector2 whereToSpawn;
	Vector2 whereToSpawnTwo;
	public float spawnRate;
	public float spawnRateTwo;
	public float NextSpawn = 0f;
	public float NextSpawn2 = 0.5f;

	void Update()
	{
		spawnRate = Random.Range (.1f, 1.5f);
		spawnRateTwo = Random.Range (.1f, 1.5f);

		if (Time.time > NextSpawn) {
			NextSpawn = Time.time + spawnRate;
			whereToSpawn = new Vector2 (transform.position.x, -1.5f);
			Instantiate (spawnPrefab [(int)Random.Range(0,spawnPrefab.Length)], whereToSpawn, Quaternion.identity);
		}
		if (Time.time > NextSpawn2) {
			NextSpawn2 = Time.time + spawnRateTwo;
			whereToSpawnTwo = new Vector2 (transform.position.x, -2.8f);
			Instantiate (spawnPrefab [(int)Random.Range(0,spawnPrefab.Length)], whereToSpawnTwo, Quaternion.identity);
		}

	}
	public void GameOver()
	{
		Destroy (this);

	}

}
