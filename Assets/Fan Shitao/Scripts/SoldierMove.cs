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
        
        // Debug.Log(collision.gameObject);
        soldier.transform.position += Vector3.forward * Time.deltaTime*moveSpeed;
        }
    }
     
}
