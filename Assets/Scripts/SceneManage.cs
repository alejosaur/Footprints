﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CargarEscena(string nombreNivel){
		SceneManager.LoadScene(nombreNivel);
	}

	public void quit(){
		Application.Quit();
	}
}
