using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float speed;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(transform.forward * speed * Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(transform.forward * -speed * Time.deltaTime);
		}
	}
}
