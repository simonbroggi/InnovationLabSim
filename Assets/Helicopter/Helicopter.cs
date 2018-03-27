using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
	public float mainRotorSpeed = 1f;
	public float heckRotorSpeed = 1f;
	public Transform mainRotor;
	public Transform heckRotor;

	public Vector3 shakeFrequency = Vector3.one;
	public float shakeAmplitude = .1f;

	// Use this for initialization
	void Start () {
		
	}

	private Vector3 offset = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
		mainRotor.Rotate(Vector3.up, mainRotorSpeed * Time.deltaTime);
		heckRotor.Rotate(Vector3.up, heckRotorSpeed * Time.deltaTime);
		Vector3 newOffset = new Vector3(Mathf.PerlinNoise(Time.time * shakeFrequency.x, .123f) -.5f,
										Mathf.PerlinNoise(Time.time * shakeFrequency.y, .456f) -.5f,
										Mathf.PerlinNoise(Time.time * shakeFrequency.z, .789f) -.5f);
		newOffset *= shakeAmplitude;
		transform.position = transform.position - offset + newOffset;
		offset = newOffset;
	}
}
