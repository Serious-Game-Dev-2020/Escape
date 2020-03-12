using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hy_PrisonCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public Rigidbody chaRigidbody;
    public int moveSpeed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        VerticalMove(Input.GetAxis("Vertical"));
    }
    void HorizontalMove(float horizontal, float vertical)
    {
        if(horizontal != 0)
        {
            chaRigidbody.velocity = new Vector3(chaRigidbody.velocity.x, chaRigidbody.velocity.y, -horizontal * moveSpeed);
            Debug.Log("平移");
        }
        else if(horizontal == 0 && vertical == 0)
        {
            chaRigidbody.velocity = Vector3.zero;
        }
    }
    void VerticalMove(float vertical)
    {
        if(vertical != 0)
        {
            chaRigidbody.velocity = new Vector3(vertical * moveSpeed, chaRigidbody.velocity.y, chaRigidbody.velocity.z);
            Debug.Log("进退");
        }
    }
    
}
