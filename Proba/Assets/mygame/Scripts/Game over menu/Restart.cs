﻿using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	public void RestartButtonClicked()
	{
		Application.LoadLevel (Application.loadedLevel);
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}