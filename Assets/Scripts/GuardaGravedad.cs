using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardaGravedad : MonoBehaviour {
	public float gravedad;
	Rigidbody2D rb;


	void Awake(){
		rb =GetComponent<Rigidbody2D> ();

		}
	// Use this for initialization
	void Start () {
		
		rb.gravityScale=1f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider2D other)
	{
		rb.gravityScale =gravedad;
	}
}
