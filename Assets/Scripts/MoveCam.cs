 using UnityEngine;
 using System.Collections;
 
 public class MoveCam : MonoBehaviour
 {
     public Transform target; //This will be your citizen
     public float distance;
     
 
     void Update()
     {
        transform.position =new Vector3(target.position.x+3, 0.56f, -7.26f);
     }
 }