using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public static Door instance;

	private Animator anim;
	private bool isTouch;
	[HideInInspector]
	public int count;
	// Use this for initialization
	void Awake(){
		Instance ();
		anim = GetComponent<Animator> ();
	}
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		
	}
	public void DecrementCollectables(){
		count--;
		Debug.Log (count);
		if(count == 0){
			anim.Play ("Open");
		}
	}

	void Instance(){
		if(instance == null){
			instance = this;
		}
	}
}
