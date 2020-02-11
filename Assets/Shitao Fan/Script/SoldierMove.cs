using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    public GameObject hit;
    public GameObject soldier;
    public float moveSpeed = 50.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponentInChildren<GameObject>();
        soldier = GetComponentInParent<GameObject>();
        
    }
     void OnTriggerEnter(Collider hit) 
    {
        
        Debug.Log("Move");
        soldier.transform.position += Vector3.forward*moveSpeed* Time.deltaTime;
        
    }

    // Update is called once per frame
    void Update()
    {
            
        
        
        // if (Input.GetKeyDown(KeyCode.A))
        // {
            
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
            // transform.position += Vector3.forward * Time.deltaTime;
        // }

        // if (Input.GetKeyUp(KeyCode.A))
        // {
            
        // }

        // if (Input.GetKeyDown(KeyCode.D))
        // {
            // transform.position += Vector3.right;
    //     }
    //     if (Input.GetKeyDown(KeyCode.W))
    //     {
    //         transform.position += Vector3.forward;
    //     }
    //     if (Input.GetKeyDown(KeyCode.S))
    //     {
    //         transform.position += Vector3.back;
    //     }
    // }
    }

   
}
