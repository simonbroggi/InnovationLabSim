using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class Auto : MonoBehaviour, IPointerClickHandler {
	public float speed;
	public ParticleSystem fire;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(transform.forward * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(transform.forward * -speed * Time.deltaTime);
		}

		// kollision
		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1f);
        int i = 0;
        while (i < hitColliders.Length)
        {
			//Debug.Log("collision with " + hitColliders[i].gameObject.name);
			if(hitColliders[i].gameObject.name == "Gegner") {
				fire.gameObject.SetActive(true);
			}
			i++;
        }
	}
	
	public void OnPointerClick(PointerEventData eventData) {
		transform.Rotate(new Vector3(0f, 10f, 0f));
	}
}
