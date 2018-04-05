using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject prefab;

	public float spawnTime;
	private float lastSpawnTime = 0f;
	
	// Update is called once per frame
	void Update () {
		if(lastSpawnTime + spawnTime <= Time.time) {
			GameObject go = GameObject.Instantiate(prefab, transform.position, transform.rotation);
			go.name = "Gegner";
			lastSpawnTime = Time.time;
		}
	}
}
