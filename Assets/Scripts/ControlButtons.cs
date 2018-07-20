using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ControlButtons : MonoBehaviour {

	public GameObject menuBackground;
	public GameObject misifu;
	private bool actual = true;
	// Use this for initialization
	void Start () {
		menuBackground.SetActive(false);
	}
	
	public void ShowBackground(){
		menuBackground.SetActive(actual);
		misifu.GetComponent<ThirdPersonUserControl>().pauseGame();
		actual = !actual;
	}

	public void jump()
	{
		misifu.GetComponent<ThirdPersonUserControl>().jump();
	}

	public void crouch(bool act)
	{
		misifu.GetComponent<ThirdPersonUserControl>().crouch(act);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
