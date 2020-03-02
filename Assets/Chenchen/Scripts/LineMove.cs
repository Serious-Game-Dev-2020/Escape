
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove : MonoBehaviour
{
    public GameObject movingpoint;
    public GameObject sphere;
    public float speed = 20f;
    public bool Smove = false;
    //public bool con = true;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Smove == true ) {
            sphere.transform.LookAt(movingpoint.transform);
            sphere.transform.position += sphere.transform.forward * 5f * Time.deltaTime;
        }
        //sphere.transform.LookAt(movingpoint.transform);
        //sphere.transform.position += sphere.transform.forward * 5f * Time.deltaTime;
        //transform.LookAt(movingpoint.transform);
        //transform.position += transform.forward * 5f * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("zhuangplayer");
       

    }
    /*void Moving()
    {
        transform.LookAt(movingpoint.transform);
        transform.position += transform.forward * 5f * Time.deltaTime;
    }*/
   
}

