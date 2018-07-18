using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour {

	public ScreenOrientation orient;

	// Use this for initialization
	void Start () {
        Screen.orientation = orient;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
