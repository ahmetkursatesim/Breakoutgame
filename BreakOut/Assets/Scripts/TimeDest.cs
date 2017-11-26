using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDest : MonoBehaviour {
	public float DestrTime=1.1f;



	void Start () {
		Destroy (gameObject, DestrTime);
		
	}
	

}
