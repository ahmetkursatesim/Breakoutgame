using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Paddle : EnemySpawnerScript {
	public float paddleSensitivity = 1f;
	private Vector3 paddlepos = new Vector3(0, -9.5f, 0);


	void Update () {
		float xpaddlePos = transform.position.x + (Input.GetAxis("Mouse X")*paddleSensitivity) ;
		paddlepos = new Vector3(Mathf.Clamp(xpaddlePos, -13f, 13f), -9.5f, 0f);
		transform.position = paddlepos;


	}
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "enemy"){
			Destroy(Enemy);
		}
	}

}
