using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerScript : MonoBehaviour {

	private Animator anim;
	public float forceY = 900f;
	// Use this for initialization
	void Awake(){
		anim = GetComponent<Animator> ();	
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator AnimateBounty(){
		anim.Play ("Up");
		yield return new WaitForSeconds (0.7f);
		anim.Play ("Down");
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			target.gameObject.GetComponent<PlayerScript> ().Bouncer (forceY);
			StartCoroutine (AnimateBounty ());
		}
	}
}
