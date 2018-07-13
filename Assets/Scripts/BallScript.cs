using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public float deltaMovement = 5f;
    public Rigidbody rb;
    private bool collided;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {   
        if (Input.GetKey(KeyCode.W) && collided)
        {
            rb.AddForce(new Vector3(0f,0.03f,0f) * 100f, ForceMode.Impulse);	
        }
        /*else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * deltaMovement * Time.deltaTime);
        }*/
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
        }
	}

    public void OnCollisionEnter(){
        //Debug.Log(other.gameObject);
        collided =true;
    }
    
    public void OnCollisionExit(){
        collided =false;
    }

    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag ("Coins"))
        {
            other.gameObject.SetActive (false);
        }
    }

}
