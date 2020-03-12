﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower1 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    public float MoveSpeed;
    public Animator character;

    private void Start()
    {

    MoveSpeed = 3.0f;
    character = gameObject.GetComponent<Animator>();

    }



     //Update is called once per frame
    void Update()
    {
    //if (Input.GetKeyDown(KeyCode.W))

    if (Input.GetKey(KeyCode.A))
    {
    Run();
    distanceTravelled += speed * Time.deltaTime;
    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }

    if (Input.GetKey(KeyCode.D))
    {
    Run();
    distanceTravelled -= speed * Time.deltaTime;
    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
    if (Input.GetKey(KeyCode.H))
    {

    PullTheDoor();

    }
    
    }




    void PullTheDoor()
    {
      character.SetTrigger("PullTheDoor");
    }
    void Run()
    {
      character.SetTrigger("Run");
    }

    
}


