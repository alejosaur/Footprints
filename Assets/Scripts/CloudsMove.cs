using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour {

	public Transform other;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position=new Vector3(transform.position.x, transform.position.y-4, transform.position.z);
		if(transform.position.y<-4495.21f){
			transform.position=new Vector3(transform.position.x, 4666, transform.position.z);
		}
	}
}
