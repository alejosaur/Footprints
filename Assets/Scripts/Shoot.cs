using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody bullet;
	public Vector3 direction;
	public string bulletName;
	public float time;
	public int simultaneas;	
	private int count=0;

	// Use this for initialization
	 void Start()
	{
		StartCoroutine(DoEveryFiveSeconds());
	}
	
	IEnumerator DoEveryFiveSeconds()
	{
		while (true)
		{
			yield return new WaitForSeconds(time);
			DoSomething();
		}
	}
	
	// happens every 0.5 seconds
	void DoSomething()
	{
		Rigidbody bala = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
    	bala.velocity = transform.TransformDirection(direction);            
		bala.name = bulletName + count;
		count++;

		GameObject delBullet = GameObject.Find(bulletName+(count-simultaneas));
		Destroy(delBullet);
	}

	void shoot(){

	}
}
