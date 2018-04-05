using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour {
	public float speed;
	// Update is called once per frame
	void Update () {
		GetComponent<MeshRenderer>().material.mainTextureOffset += Vector2.down * speed * Time.deltaTime;
	}
}
