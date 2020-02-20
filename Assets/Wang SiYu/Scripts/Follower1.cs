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
    public float pullSpeed;
    Animator moveCharacter;
    GameObject cube;
    
    

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

        if (Input.GetKey(KeyCode.H))
        {
                moveCharacter.SetBool("PullTheDoor", true);
                distanceTravelled -= speed * pullSpeed*Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
                transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
                
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
                moveCharacter.SetBool("PullTheDoor", false);
        }

    }

    void Run()

    {
        if (!Input.GetKey(KeyCode.H))
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


        
    
}


