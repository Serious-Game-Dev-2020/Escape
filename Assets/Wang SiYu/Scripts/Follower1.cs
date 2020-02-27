using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower1 : MonoBehaviour
{
    public PathCreator pathCreator;
    public PathCreator pathCreator2;
    public float moveSpeed = 5.0f;
    public float horizontalDistance;
    public float verticalDistance;
    //public float MoveSpeed;
    public GameObject Chararacter;
    public Rigidbody charaRigidbody;
    public bool followCondition = true;
    public bool verticalCondition = true;

    void Start()
    {
    verticalDistance = 0.5f;
    }
     //Update is called once per frame
    void Update()
    {
    //if (Input.GetKeyDown(KeyCode.W))
    HorizontalMove(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    VerticalMove(Input.GetAxis("Vertical"));
    if(followCondition == true)
    {
    pathCreator2.transform.position = transform.position;
    pathCreator2.transform.rotation = transform.rotation;
    }
    if(Input.GetAxis("Horizontal") != 0)
    {
        verticalCondition = false;
    }
    if(Input.GetAxis("Horizontal") == 0)
    {
        verticalCondition = true;
    }

    /*if (Input.GetKey(KeyCode.W))
    {
    transform.position = pathCreator.path.GetPointAtDistance(horizontalDistance);
    transform.rotation = pathCreator.path.GetRotationAtDistance(horizontalDistance);
    }
    else if  (Input.GetKey(KeyCode.Q))
    {
    transform.position = pathCreator.path.GetPointAtDistance(-horizontalDistance);
    transform.rotation = pathCreator.path.GetRotationAtDistance(-horizontalDistance);
    }*/
    }
    void HorizontalMove(float horizontal, float vertical)
    {
        if(horizontal != 0)
        {
            followCondition = true;
            verticalDistance = 0.5f;
            horizontalDistance += moveSpeed * horizontal;
            charaRigidbody.position = pathCreator.path.GetPointAtDistance(horizontalDistance);
            charaRigidbody.rotation = pathCreator.path.GetRotationAtDistance(horizontalDistance);
            if (horizontalDistance <= 0.2f )
            {
                horizontalDistance = 0.2f;
            }
            //charaRigidbody.velocity = new Vector3(charaRigidbody.velocity.x, charaRigidbody.velocity.y, -horizontal * moveSpeed);
            Debug.Log("平移");
        }
        else if(horizontal == 0 && vertical == 0)
        {
            charaRigidbody.velocity = Vector3.zero;
        }
    }
    void VerticalMove(float vertical)
    {
        if(vertical != 0 && verticalCondition == true)
        {
            followCondition = false;
            verticalDistance += moveSpeed * -vertical * 0.2f;
            //charaRigidbody.position = pathCreator2.path.GetPointAtDistance(verticalDistance);
            charaRigidbody.position = pathCreator2.path.GetPointAtDistance(verticalDistance);
            if(verticalDistance <= 0.1f)
            {
                verticalDistance = 0.1f;
            }
            else if(verticalDistance >= 0.9f)
            {
                verticalDistance = 0.9f;
            }
            //charaRigidbody.velocity = new Vector3(vertical * moveSpeed, charaRigidbody.velocity.y, charaRigidbody.velocity.z);
            Debug.Log("进退");
        }
    }
    
}

