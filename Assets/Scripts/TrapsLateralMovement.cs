using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsLateralMovement : MonoBehaviour {

	Rigidbody rb;
	public float multiplier;
	public float max;
	public float min;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(1f,0f,0f)*multiplier;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x>=max )
		{
			rb.velocity = new Vector3(-1f,0f,0f)*multiplier;
		}
		else if(transform.position.x<=min )
		{
			rb.velocity = new Vector3(1f,0f,0f)*multiplier;
		}
	}
}
