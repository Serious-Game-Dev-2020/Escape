
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed ;
    public GameObject player;
    public GameObject sphere;
    //public GameObject sphere1;
    LineMove Lm;

    void Start()
    {
        speed = 10f;
        Lm = FindObjectOfType<LineMove >();
        //DL = FindObjectOfType<DrawLine>();

    }


    void Update()
    {
        transform.position = new Vector3(transform.position.x, 0.51f, transform.position.z);
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontal, 0, vertical);


    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("zhuanghaha");
       sphere.transform.parent = player.transform;
 

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Bianjie")
            {
               Lm.Smove = true;
            //sphere.transform.parent = player.transform;

            //DL.sheCondition = true;
            Debug.Log("碰撞");
            }

       /*if (collision.gameObject.name == "Sphere")
        {
            //sphere.transform.parent = player.transform;
          // sphere.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
           // Lm.con = false;
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("变子集");
        }*/

    }
    }
