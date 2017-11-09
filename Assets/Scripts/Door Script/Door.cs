using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	private Animator anim;
	private bool isTouch;
	// Use this for initialization
	void Awake(){
		anim = GetComponent<Animator> ();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void OnTriggerEnter2D(Collider2D target){
		
	}
}
