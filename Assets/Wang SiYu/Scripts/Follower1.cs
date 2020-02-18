using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower1 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    public float MoveSpeed;
    public GameObject character;
    Animator moveCharacter;
    

    private void Start()
    {

        MoveSpeed = 3.0f;
        moveCharacter = character.GetComponent<Animator> ();
        

    }



    //Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        PullTheDoor(); 
        Run();    
    }

    void PullTheDoor()

    {

        if (Input.GetKeyDown(KeyCode.H))
        {
                moveCharacter.SetBool("PullTheDoor", true);
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
                moveCharacter.SetBool("PullTheDoor", false);
        }

    }

    void Run()

    {
        if (Input.GetKey(KeyCode.D))
        {
            moveCharacter.SetBool("Run", true);
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            moveCharacter.SetBool("Run", false);
            
        }
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
            moveCharacter.SetBool("Run", true);
            distanceTravelled -= speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            moveCharacter.SetBool("Run", false);
            
        }
    }


        
    
}


