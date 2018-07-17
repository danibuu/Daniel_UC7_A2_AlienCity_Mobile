using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FimdeJogo : MonoBehaviour {


	public static bool fimdejogoOn;
	public Image img;

	// Use this for initialization
	void Start () {
		img.enabled = false;
		fimdejogoOn = false;
	}

	void Update () {
		if (Armadilha.lives == -1 )
		{
			img.enabled = true;
			fimdejogoOn = true;
			if (Input.GetKeyDown(KeyCode.R))
			{

				Armadilha.lives += 3;
				//Score.scorevalue = 0;
				img.enabled = false;
				fimdejogoOn = false;
				//Timecounter.timeLeft = 40.0f;
				SceneManager.LoadScene("Jogo");
			}
		}
	}
}
