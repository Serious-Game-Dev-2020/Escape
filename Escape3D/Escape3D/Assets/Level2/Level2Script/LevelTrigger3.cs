﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "Boat")
        {
            Debug.Log("Level 3 Trigger");
        }
    }
}
