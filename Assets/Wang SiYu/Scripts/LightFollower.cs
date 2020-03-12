using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class LightFollower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    //public float MoveSpeed;

    //private void Start()
    //{
    //MoveSpeed = 5.0f;

    // }



    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))

        if (Input.GetKey(KeyCode.G))
        {

            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
    }
}

