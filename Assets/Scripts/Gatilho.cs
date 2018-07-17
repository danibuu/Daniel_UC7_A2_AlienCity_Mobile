using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatilho : MonoBehaviour {


	public static bool range;

	// Use this for initialization
	private void Start()
	{
		range = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			range = true;
			Destroy(gameObject);
		}
	}
}
