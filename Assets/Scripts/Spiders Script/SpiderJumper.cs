using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour {

	public float speed = 20f;
	public float jump = 400f;

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
		yield return new WaitForSeconds (Random.Range(2,7));
		StartCoroutine (Attack ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
