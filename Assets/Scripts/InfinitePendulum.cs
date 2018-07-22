using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePendulum : MonoBehaviour {

	private bool bajando;
    private Rigidbody rb;
	public float trust;
	private float y;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		bajando = true;
		y = transform.position.y;
		Debug.Log(y);
	}
	
	// Update is called once per frame
	void Update () {
		if (bajando && transform.position.y > y)
        {
            bajando = false;
            rb.AddForce(rb.velocity * trust);
        }
        if (!bajando && transform.position.y <y)
        {
			Debug.Log(transform.rotation);
            bajando = true;
        }
        y = transform.position.y;
	}
}
