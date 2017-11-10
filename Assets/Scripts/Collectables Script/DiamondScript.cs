using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour {

	// Use this for initialization

	void Awake(){
		
	}
	void Start () {
		if(Door.instance != null){
			Door.instance.count++;
			Debug.Log (Door.instance.count);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.tag == "Player"){
			Door.instance.DecrementCollectables ();
			Destroy (gameObject);

		}
	}
}
