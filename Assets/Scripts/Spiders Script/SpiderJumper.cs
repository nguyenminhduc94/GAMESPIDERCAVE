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
		StartCoroutine (Attack ());
	}

	IEnumerator Attack(){
		yield return new WaitForSeconds (Random.Range(1,4));
		anim.SetBool ("Attack",true);
		float forceY = Random.Range (200f, 400f);
		myBody.AddForce (new Vector2 (0f, forceY));
		//myBody.velocity = new Vector2 (0f, forceY);
		yield return new WaitForSeconds (1);
		StartCoroutine (Attack ());	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			DestroyObject (target.gameObject);
		}
		if(target.tag == "Ground"){
			anim.SetBool ("Attack", false);
		}
	}
}
