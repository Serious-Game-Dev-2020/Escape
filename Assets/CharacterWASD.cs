using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWASD : MonoBehaviour
{
    public float movementSpeed;
    public float distance;
    // float horizontal;
    // float vertical;

    public Transform playerCamera;
    Animator moveCharacter;
 
    public float moveSpeed;
    public float rotationSpeed;
    Rigidbody Character;
    
    float translation;
    float strafe;


    float vertical;
    float horizontal;
    
    void Update () 
    {
         Character = GetComponent<Rigidbody>();
         ControllPlayer();
    }
 
 
     void ControllPlayer()
     {
         float moveHorizontal = Input.GetAxisRaw ("Horizontal");
         float moveVertical = Input.GetAxisRaw ("Vertical");
        
 
         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
         
        if (movement != Vector3.zero)
        {
         transform.rotation = Quaternion.LookRotation(movement);
        }
 
         transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
         transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
     
          Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
          targetDirection = Camera.main.transform.TransformDirection(targetDirection);
          targetDirection.y = 0.0f;
     }

 

}
