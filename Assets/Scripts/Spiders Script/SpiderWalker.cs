using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalker : MonoBehaviour {
	private float speed = 15f;

	[SerializeField]
	private Rigidbody2D myBody;
	//private Animator anim;
	// Use this for initialization
	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		//anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//myBody.velocity = new Vector2 (transform.localScale.x, 0)*speed;
		myBody.AddForce(new Vector2(transform.localScale.x,0)*speed);
		Debug.Log (myBody.velocity);
	}
}
