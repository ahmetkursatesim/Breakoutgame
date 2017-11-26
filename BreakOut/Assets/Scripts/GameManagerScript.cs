using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {
	public int lives = 3;
	public int Bricks = 24;
	public int sc=0;
	public int hsc=0;
	public float resetDelay = 10f;
	public Text livesText;
	public Text Scoretext;
	public Text HighScoretext;

	public GameObject gameOver;

	public GameObject Button;
	public GameObject youWon;
	public GameObject bricksPrefab;
	public GameObject Paddle;
	public GameObject deathParticles;
	public Text Timetext;
	public static GameManagerScript instance = null;
	private GameObject clonePaddle;
	public int scoreint = 0;

	void Start () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		Setup ();

		
	}
	 
	public void Setup(){
		
		clonePaddle = Instantiate (Paddle, transform.position, Quaternion.identity)as GameObject;

		Instantiate (bricksPrefab,transform.position ,Quaternion.identity);



	}
	void CheckGameOver(){

		if (Bricks < 1) {
			youWon.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);

		}
		if (lives < 1) {
			
			gameOver.SetActive (true);
		
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);

				Button.SetActive (true);
			HighScoretext.text = "HighScore" + hsc;
		
		



			
		}



	}
	public int sayi = 60; // 60'dan geriye sayacak bir değer oluşturuyoruz int türünde, adı sayi
	public float zaman = 20; // birer birer ve yavaş inmesi için zaman oluşturuyoruz float çünkü (yavaş olması için)
	void Update () {
		if(zaman > 0) { // zaman değeri 0'dan büyük ise
			zaman--; // değeri düşür
			Timetext.text = "Time:" + sayi;
			if (sayi == 0) {
				lives=0;

				CheckGameOver ();
			
				

			}

		}
		else { // değil ise
			zaman = 20; // zaman'ı 10 yap
			sayi--; // sayi değerini 1 düşür
		}
	}
	void Reset(){
		sc= 0;
		Time.timeScale = 10f;
		Application.LoadLevel(Application.loadedLevel);

	}
	public void LoseLife(){
		
		
		lives--;
		livesText.text = "Lives:" + lives;

	
		Instantiate (deathParticles, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Invoke ("SetupPaddle", resetDelay);
		CheckGameOver ();


	}
	void SetupPaddle(){
		clonePaddle = Instantiate (Paddle, transform.position, Quaternion.identity)as GameObject;

	}
	public void  DestroyBrick(){
		
		Bricks--;
		scoreint++;

		AddPoints (scoreint);


		CheckGameOver();

	}


	


	void AddPoints (int pointsToAdd)
	{
		sc += pointsToAdd;
		int a = sc * 10;
		Scoretext.text = "Score:" + a;

		if (a> hsc) {
			hsc = a;


		}
		HighScoretext.text = "HighScore:" + hsc;

	}

	}












