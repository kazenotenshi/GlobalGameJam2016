﻿using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Die(){
		gameObject.SetActive (false);
	}

}
