using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed ;
    public GameObject player;
    public GameObject sphere;
    LineMove Lm;

    void Start()
    {
        speed = 10f;
        Lm = FindObjectOfType<LineMove >();
        //DL = FindObjectOfType<DrawLine>();

    }


    void Update()
    {
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
          

            //DL.sheCondition = true;
            Debug.Log("Do something here");
            }

        if (collision.gameObject.name == "Bianjie2")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something else here");
        }

    }
    }
