using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			DestroyObject (target.gameObject);
			DestroyObject (gameObject);
		}
		if(target.tag == "Ground"){
			DestroyObject (gameObject);
		}
	}
}
