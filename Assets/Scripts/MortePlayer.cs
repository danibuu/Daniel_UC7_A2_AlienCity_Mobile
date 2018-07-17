using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MortePlayer : MonoBehaviour {

	public string cena;

	void OnTriggerEnter () {
		SceneManager.LoadScene (cena);
	}

}

