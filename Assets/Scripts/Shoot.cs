using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public Vector3 direction;

	// Use this for initialization
	 void Start()
	{
		StartCoroutine(DoEveryFiveSeconds());
	}
	
	IEnumerator DoEveryFiveSeconds()
	{
		while (true)
		{
			yield return new WaitForSeconds(2f);
			DoSomething();
		}
	}
	
	// happens every 0.5 seconds
	void DoSomething()
	{
		Rigidbody cube = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
    	cube.velocity = transform.TransformDirection(direction);
	}

	void shoot(){

	}
}
