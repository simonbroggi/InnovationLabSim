using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z <= -14f){
			Vector3 odlPos = transform.position;
			transform.position = new Vector3(odlPos.x, odlPos.y, 14f);
		}
	}
}
