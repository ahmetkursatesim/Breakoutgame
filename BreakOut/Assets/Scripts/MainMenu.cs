using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour {
	




	public void StartGame()
	{

		Application.LoadLevel (1);

	}
	public void returnGame()
	{

		Application.LoadLevel (0);

	}

	public void HighScoreGame()
	{

		Application.LoadLevel (2);

	}

	public void Quit()
	{
		Application.Quit();
	}

}