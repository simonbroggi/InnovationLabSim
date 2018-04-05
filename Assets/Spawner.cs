using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] prefabs;
	public float spawnTime;
	private float lastSpawnTime = 0f;
	public GameObject[] spawnPoints;
	
	// Update is called once per frame
	void Update () {
		if(lastSpawnTime + spawnTime <= Time.time) {
			Debug.Log("kollision: " + gameObject.name  );
			GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
			GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
			GameObject go = GameObject.Instantiate(prefab, spawnPoint.transform.position,
														   spawnPoint.transform.rotation);
			go.name = go.name.Substring(0, go.name.Length - 7);
			lastSpawnTime = Time.time;
		}
	}
}
