using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour {

	public float speed = 20f;
	public float jump = 300f;
	private bool isJump;

	[SerializeField]
	private Rigidbody2D myBody;
	private Animator anim;
	// Use this for initialization
	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Start () {
		
	}

	IEnumerator Attack(){
		if(isJump){
			isJump = false;
			yield return new WaitForSeconds (Random.Range(1,2));
			myBody.AddForce (new Vector2 (0f, jump));
			anim.SetBool ("Attack",true);
			StartCoroutine (Attack ());	
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		StartCoroutine (Attack ());
	}

	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Ground"){
			isJump = true;
			anim.SetBool ("Attack",false);
			StartCoroutine (Attack ());
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			DestroyObject (target.gameObject);
		}
	}
}
