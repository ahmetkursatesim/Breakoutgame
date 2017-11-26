using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	public GameObject Enemy;

	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn=10.0f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (-10f, 10f);
			whereToSpawn = new Vector2 (randX,10f);
			Instantiate (Enemy,whereToSpawn,Quaternion.identity);	
		}


		
	}

	void  OnTriggerEnter(Collider col){
		if (col.tag == "Player"){ // check if it's the player, if you want

			GameManagerScript.instance.LoseLife ();
		}
	}

}
