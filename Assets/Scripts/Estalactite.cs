using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estalactite : MonoBehaviour {


	public Animator anim;
	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}
	void OnTriggerEnter(Collider col)
	{
		if(Gatilho.range == true)
		{
			Armadilha.lives -= 1;
			Destroy(col.gameObject);
			SceneManager.LoadScene("Jogo");
		}
	}
}
