using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MisifuScript : MonoBehaviour {

    public float deltaMovement = 5f;
    private Rigidbody rb;
    private bool collided;
    private int count;
    public Text PuntajeText;
    private bool start;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
        count = 0;
        start=false;
	}
	
	// Update is called once per frame
	void Update () 
    {   
        
	}

    void startMoving(){
    }

    public void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag ("Coins"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
        else if (other.gameObject.CompareTag ("Traps"))
        {   
		    SceneManager.LoadScene("Game Over");
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
