using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour {
public static bool si;


	// Use this for initialization
	void Start () {
			si= false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player"){
			si = true;
				
		}
		
	}
	void OnTriggerExit2D(Collider2D col) {
				if(col.gameObject.tag == "Player"){
			si = false;
		}
}
}