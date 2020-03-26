using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    public GameObject hit;
    public GameObject soldier;
    public float moveSpeed = 55.0f;

    public GameObject backsolider;
    
    
    // Start is called before the first frame update
    void Start()
    {
        hit = GetComponentInChildren<GameObject>();
        soldier = GetComponentInParent<GameObject>();
        
    }
     void OnTriggerEnter(Collider hit) 
    {
        
        // Debug.Log("WasHit");
        soldier.transform.Translate(Vector3.left * Time.deltaTime*moveSpeed, Camera.main.transform);
        
    }

     void OnCollisionEnter(Collision hit) 
    {
        if (hit.gameObject.tag == "backsolider")
        
        Debug.Log("shit");
        
    }
}
