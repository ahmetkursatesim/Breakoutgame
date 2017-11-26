using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreSc : GameManagerScript {
	public Text HighScoreText;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Highscore () {
		
		HighScoreText.text = "HighScore:"+hsc;
		
	}
}
