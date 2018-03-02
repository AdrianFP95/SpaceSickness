using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioGravedad : MonoBehaviour {


	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			Physics2D.gravity = new Vector2 (0f, 4f);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Physics2D.gravity = new Vector2 (0f, -4f);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Physics2D.gravity = new Vector2 (4f, 0f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Physics2D.gravity = new Vector2 (-4f, 0f);
		}


	}
}
