using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirController : MonoBehaviour {

	private Slider slider;
	private GameObject player;
	private float maxAir = 10f;
	private float burnAir = 1f;

	// Use this for initialization
	void Awake(){
		GetPreferences ();
	}

	void Start () {
		
	}
	public void plusCollectable(){
		maxAir += 1f;
		slider.value = maxAir;
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null)
			return;
		if (maxAir > 0) {
			maxAir -= burnAir * Time.deltaTime;
			slider.value = maxAir;
		} else {
			Destroy (player);
		}
	}

	void GetPreferences(){
		player = GameObject.Find ("CharacterMoving");
		slider = GameObject.Find ("Air").GetComponent<Slider>();

		slider.maxValue = maxAir;
		slider.minValue = 0f;
	}
}
