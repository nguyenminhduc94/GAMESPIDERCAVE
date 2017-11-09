using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalker : MonoBehaviour {
	private bool collision;

	//[SerializeField]
	private float speed = 5f;
	public Transform startPos, endPos;
	private Rigidbody2D myBody;
	private Animator anim;

	// Use this for initialization
	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}

	void ChangeDirection(){
		myBody.velocity = new Vector2 (transform.localScale.x, 0)*speed;
		Debug.DrawLine (startPos.position,endPos.position,Color.green);
		collision = Physics2D.Linecast (startPos.position,endPos.position,1 << LayerMask.NameToLayer("Ground"));
		if(!collision){
			Vector3 vc3 = transform.localScale;
			if (vc3.x == 1f) {
				vc3.x = -1f;
			} else {
				vc3.x = 1f;
			}
			transform.localScale = vc3;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ChangeDirection ();
		//myBody.AddForce (new Vector2 (transform.localScale.x, 0)*speed);
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Player"){
			DestroyObject (target.gameObject);
		}
		if(target.gameObject.tag == "SpiderJumper" || target.gameObject.tag == "SpiderWalker"){
			Vector3 vc3 = transform.localScale;
			if (vc3.x == 1f) {
				vc3.x = -1f;
			} else {
				vc3.x = 1f;
			}
			transform.localScale = vc3;
		}
	}
}
