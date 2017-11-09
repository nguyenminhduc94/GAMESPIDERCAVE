using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	public float speed = 20f;
	public float jump = 100f;
	private bool isJump;
	[SerializeField]
	private Rigidbody2D myBody;
	private Animator anim;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CharacterMoving ();
	}

	void CharacterMoving(){
		float forceX = 0f,forceY = 0f;
		float key = Input.GetAxisRaw("Horizontal");
		float vel = Mathf.Abs (myBody.velocity.x);
		Vector3 vc3 = transform.localScale;
		if (key < 0) {
			if(vel < 4f){
				if (isJump) {
					forceX = -speed;
				} else {
					forceX = -speed * 1.1f;
				}
				vc3.x = -1f;
				anim.SetBool ("Walk", true);
			}
		} else if (key > 0) {
			if(vel < 4f){
				if (isJump) {
					forceX = speed;
				} else {
					forceX = speed * 1.1f;
				}
				vc3.x = 1f;
				anim.SetBool ("Walk", true);
			}
		} else {
			anim.SetBool ("Walk", false);
			forceX = 0f;
		}

		if(Input.GetKey(KeyCode.Space)){
			if(isJump){
				isJump = false;
				forceY = jump;
			}
		}
		transform.localScale = vc3;
		Vector2 vc2 = new Vector2 (forceX, forceY);
		myBody.AddForce (vc2);
	}
		
	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Ground"){
			isJump = true;
		}
	}
}
