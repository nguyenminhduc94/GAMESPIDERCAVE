using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

	private Slider slider;
	private GameObject player;
	private float maxTimer = 10f;
	private float burnTimer = 1f;

	// Use this for initialization
	void Awake(){
		GetPreferences ();
	}

	void Start () {

	}

	// Update is called once per frame
	public void plusCollectable(){
		maxTimer += 1f;
		slider.value = maxTimer;
	}
	void Update () {
		if (player == null)
			return;
		if (maxTimer > 0) {
			maxTimer -= burnTimer * Time.deltaTime;
			slider.value = maxTimer;
		} else {
			Destroy (player);
		}
	}

	void GetPreferences(){
		player = GameObject.Find ("CharacterMoving");
		slider = GameObject.Find ("Timer").GetComponent<Slider>();

		slider.maxValue = maxTimer;
		slider.minValue = 0f;
	}
}
