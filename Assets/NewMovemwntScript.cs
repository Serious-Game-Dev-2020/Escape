using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovemwntScript : MonoBehaviour
{
public Transform playerCamera;
 
public float moveSpeed;
public float rotationSpeed;
 
float translation;
float strafe;
 
void FixedUpdate () {
 
    //Movement
    strafe =  Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
    translation = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
 
    Vector3 movement = new Vector3 (strafe, 0f, translation);
 
    if (movement != Vector3.zero) {
        transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (movement), rotationSpeed);
    }
 
    transform.Translate (playerCamera.TransformDirection(movement));
}
}
