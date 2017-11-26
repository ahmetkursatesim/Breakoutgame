using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public float startVelocity = 600f;
	private Rigidbody ball;
	private bool bPlay;
	void Awake () {
		ball = GetComponent<Rigidbody> ();

		
	}
	

	void Update () {
		if (Input.GetButtonDown ("Fire1") && bPlay == false) {

			transform.parent = null;
			bPlay = true;
		ball.isKinematic = false;
		ball.AddForce (new Vector3 (startVelocity,startVelocity, 0));
		}
	}
}
