using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform player;
	public float minX, maxX;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("CharacterMoving").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 vc3 = transform.position;
			vc3.x = player.position.x;


			if(vc3.x < minX){
				vc3.x = minX;
			}

			if(vc3.x > maxX){
				vc3.x = maxX;
			}
			transform.position = vc3;
		}
	}
}
