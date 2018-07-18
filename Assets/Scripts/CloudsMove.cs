using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position=new Vector3(transform.position.x-4, transform.position.y, transform.position.z);
		if(transform.position.x<-6769){
			transform.position=new Vector3(2460, transform.position.y, transform.position.z);
		}
	}
}
