using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    public GameObject soldier;
    public float moveSpeed = 100.0f;

     void OnTriggerEnter(Collider collision) 
    {
        if (collision.tag == "Hit")
        {
        
        Debug.Log(collision.gameObject);
        soldier.transform.Translate(Vector3.left * Time.deltaTime*moveSpeed, Camera.main.transform);
        }
    }

     void OnCollisionEnter(Collider collision) 
    {
        if (collision.tag == "Parent")
        {
        
        Debug.Log("shit");
        }
    }

    

     
}
