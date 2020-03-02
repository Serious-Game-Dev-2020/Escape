using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSoliderMove : MonoBehaviour
{
    public GameObject soldier;
    public float moveSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {

        soldier = GetComponentInParent<GameObject>();
        
    }

    public void Move() 
    {
        
        Debug.Log("Move");
        soldier.transform.position += Vector3.forward*moveSpeed* Time.deltaTime;
        
    }
}
