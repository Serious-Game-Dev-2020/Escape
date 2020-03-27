using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    public GameObject soldier;
    public float moveSpeed = 55.0f;

    public GameObject collision;
    
     void FixedUpdate() 
     
    {
        
        
    }
    
     void OnTriggerEnter(Collider collision) 
    {
        if (collision.tag == "Hit")
        {
        
        Debug.Log(collision.gameObject);
        soldier.transform.Translate(Vector3.left * Time.deltaTime*moveSpeed, Camera.main.transform);
        }
    }

     void OnCollisionEnter(Collision hit) 
    {
        if (hit.gameObject.tag == "backsolider")
        
        Debug.Log("shit");
        
    }
}
