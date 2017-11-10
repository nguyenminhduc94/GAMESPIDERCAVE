using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("CharacterMoving").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 vc3 = transform.position;
			vc3.x = player.position.x;
			transform.position = vc3;
		}
	}
}
