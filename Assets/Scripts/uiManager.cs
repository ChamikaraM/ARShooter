using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class uiManager : MonoBehaviour {

	public static Text scoreText;
	public static int score;
	public static bool gameOver = false;
	public static Text timeLeft;
	public static int time;

	// Use this for initialization
	void Start () {
		score = 0;
		time = 15;
		scoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Text> ();
		timeLeft = GameObject.FindGameObjectWithTag ("TimeCount").GetComponent<Text> ();
		StartCoroutine(StartCountdown ());
	}

	// Update is called once per frame


	public static void updateScore(){
		if (gameOver == false) {
			score += 1;
			scoreText.text = "Score: " + score;
		}
	}

	static IEnumerator StartCountdown()
	{
		while (time >= 0)
		{
			timeLeft.text = "Time Left: " + Mathf.Round(time);
			time -= 1;
			yield return new WaitForSeconds(1);
		}
		timeLeft.text = "Times Up !";
		gameOver = true;
	}

	public void BackButton(){
		SceneManager.LoadScene (1);
	}

}
