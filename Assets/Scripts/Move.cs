using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float vel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (vel * Time.deltaTime, 0, 0);
		}
	}
}
