using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public float deltaMovement = 5f;
	public GameObject character;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(character.transform.position.x - transform.position.x >= 6)
		{
			transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
		}
		else if(character.transform.position.x - transform.position.x <= -6)
		{
			transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
		}
	}
}
