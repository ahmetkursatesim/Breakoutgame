using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksScript : MonoBehaviour {

	public GameObject Brick_p;
	void OnCollisionEnter(Collision other){

		Instantiate (Brick_p, transform.position, Quaternion.identity);
		GameManagerScript.instance.DestroyBrick ();
		Destroy (gameObject);

	}

}
