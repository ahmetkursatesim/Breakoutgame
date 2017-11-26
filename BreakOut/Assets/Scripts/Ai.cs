using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai :GameManagerScript {

	public Transform target;
	public Transform enemy;
	public Transform monster;
	float f_RotSpeed=10.0f,f_MoveSpeed = 4.0f;
	void Start () {


			target = GameObject.FindGameObjectWithTag ("Player").transform; 
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), f_RotSpeed * Time.deltaTime);


			transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

		

	}

		



	void Update () {

	 
		if (transform.position.y>-2.0) {
			target = GameObject.FindGameObjectWithTag ("Player").transform; 

			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), f_RotSpeed * Time.deltaTime);

			transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;


		
		}else{

		

			transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

		}
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	

	}

	void  OnTriggerEnter(Collider col){
		if (col.tag == "Player"){ // check if it's the player, if you want

			GameManagerScript.instance.LoseLife ();
		}
	}

}


