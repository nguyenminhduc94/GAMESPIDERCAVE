using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAndAirScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			if (gameObject.name == "Air Collectable") {
				GameObject.Find ("Game Play Controller").GetComponent<AirController> ().plusCollectable ();
			} else {
				GameObject.Find ("Game Play Controller").GetComponent<TimerController> ().plusCollectable ();
			}
			Destroy (gameObject);
		}
	}
}
