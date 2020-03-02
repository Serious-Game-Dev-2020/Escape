using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        VerticalMove(Input.GetAxis("Horizontal"));
    }
    void HorizontalMove(float horizontal, float vertical)
    {
        if(horizontal != 0)
        {
            playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x, playerRigidbody.velocity.y, horizontal * moveSpeed);
            Debug.Log("进退");
        }
        else if(horizontal == 0 && vertical == 0)
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }
    void VerticalMove(float vertical)
    {
        if(vertical != 0)
        {
            playerRigidbody.velocity = new Vector3(vertical * moveSpeed, playerRigidbody.velocity.y, playerRigidbody.velocity.z);
            Debug.Log("平移");
        }
    }
    /*void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.name == "Bianjie")
        {
            Debug.Log("碰撞");
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bianjie")
        {
            Debug.Log("碰撞");
        }
    }
}
