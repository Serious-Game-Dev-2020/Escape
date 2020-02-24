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
        PullTheDoor(); 
        Run();    
    }

    void PullTheDoor()

    {
        

        if (Input.GetKeyDown(KeyCode.H))
        {
                character.SetBool("PullTheDoor", true);
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
                character.SetBool("PullTheDoor", false);
        }

    }

    void Run()

    {
        if (Input.GetKey(KeyCode.A))
        {
            character.SetBool("Run", true);
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            character.SetBool("Run", false);
            
        }
        

        if (Input.GetKey(KeyCode.D))
        {
            character.SetBool("Run", false);
            distanceTravelled -= speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            character.SetBool("Run", false);
            
        }
    }


        
    
}


