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
        if (Input.GetMouseButtonDown(0) && collided)
        {
            rb.AddForce(new Vector3(0f,0.03f,0f) * 300f, ForceMode.Impulse);	
        }
        

	}

    public void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag ("Floor")){
            collided =true;
            Debug.Log("Uncollided");
        }
    }
    
    public void OnCollisionExit(Collision other){
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag ("Floor")){
            collided =false;
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * deltaMovement * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * deltaMovement * Time.deltaTime);
            }
        }
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
