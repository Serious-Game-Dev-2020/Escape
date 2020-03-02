using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CharacterMove : MonoBehaviour
{
    public PathCreator pathCreator;
    public PathCreator pathCreator2;
    public GameObject coorCube;
    public float moveSpeed = 5.0f;
    public float walkMoveSpeed = 5.0f;
    public float horizontalDistance;
    public float verticalDistance;
    //public float MoveSpeed;
    public GameObject Character;
    public Rigidbody charaRigidbody;
    public bool followCondition = false;
    public bool verticalCondition = true;
    Animator moveCharacter;
    public float timer = 0.0f;

    void Start()
    {
    verticalDistance = 0.5f;
    moveCharacter = Character.GetComponent<Animator> ();
    
    
    // int finishedLevel = PlayerPrefs.GetInt("FinishedLevel"); // This goes on the main menu canvas and decides what buttons work
    
    // switch (finishedLevel) {
    //     case 0:
    //         // start at level 1
    //         break;
    //     case 1:
    //         // start at level 2
    //         break;
    // }

    // // if (currentLevel == 0)
    // // {
    // //     // do this
    // // } else if (currentLevel == 1)
    // // {
    // //     // do this instead
    // // }

    // PlayerPrefs.SetInt("FinishedLevel", 1 ); // This goes at the end of every level so it updates when the player finishes it
        
    }
     //Update is called once per frame
    void Update()
    {
    //if (Input.GetKeyDown(KeyCode.W))
    HorizontalMove(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    VerticalMove(Input.GetAxis("Horizontal"));
    if(followCondition == true)
    {
    pathCreator2.transform.position = transform.position;
    pathCreator2.transform.rotation = transform.rotation;
    coorCube.transform.position = transform.position;
    coorCube.transform.rotation = transform.rotation;
    }
    if(Input.GetAxis("Vertical") != 0)
    {
        verticalCondition = false;
    }
    if(Input.GetAxis("Vertical") == 0)
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
            charaRigidbody.velocity = new Vector3(charaRigidbody.velocity.x, charaRigidbody.velocity.y, -horizontal * walkMoveSpeed);
            timer += Time.deltaTime;
            if(timer >= 1.0f)
            {
                moveCharacter.SetBool("Run", true);
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
        }
        else if(horizontal == 0)
        {
            timer = 0.0f;
            if(vertical == 0)
            {
                charaRigidbody.velocity = Vector3.zero;
                moveCharacter.SetBool("Run", false);
            }
        }
    }
    void VerticalMove(float vertical)
    {
        if(vertical != 0 && verticalCondition == true)
        {
            followCondition = false;
            verticalDistance += moveSpeed * vertical * 0.2f;
            //charaRigidbody.position = pathCreator2.path.GetPointAtDistance(verticalDistance);
            //charaRigidbody.position = pathCreator2.path.GetPointAtDistance(verticalDistance);
            charaRigidbody.velocity = new Vector3(-vertical * walkMoveSpeed, charaRigidbody.velocity.y, charaRigidbody.velocity.z);
            if(verticalDistance <= 0.1f)
            {
                verticalDistance = 0.1f;
            }
            else if(verticalDistance >= 0.5f)
            {
                verticalDistance = 0.5f;
            }
            Debug.Log("进退");
        }
    }
    /*void RotationYTransfer(float rotationY)
    {
        if(rotationY > 180.0f)
        {
            rotationY = rotationY - 360.0f;
        }
        return rotationY;
    }*/
}
