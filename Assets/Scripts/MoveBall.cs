using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

    public float deltaMovement = 10f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb = GetComponent<Rigidbody>();
		if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * deltaMovement * Time.deltaTime);
            rb.AddForce(new Vector3(0f,0.006f,0f) * 100f, ForceMode.Impulse);	
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
        }
	}
}
