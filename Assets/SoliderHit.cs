using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoliderHit : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider collision) 
    {
        if (collision.tag == "Parent")
        {
        
        Debug.Log("shit");
        }
    }
}
