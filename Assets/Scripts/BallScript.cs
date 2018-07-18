using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour {

    public float deltaMovement = 5f;
    private Rigidbody rb;
    private bool collided;
    private int count;
    public Text PuntajeText;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
        count = 0;
        rb.velocity=(Vector3.right * deltaMovement * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () 
    {   
	}

    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag ("Coins"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText(){
        PuntajeText.text = "Puntaje: " + count.ToString() + " puntos";
    }

    private void stop(){
            rb.velocity=(Vector3.right * 0 * Time.deltaTime);
            rb.angularVelocity=(Vector3.right * 0 * Time.deltaTime);
            rb.rotation = Quaternion.identity;
    }

}
