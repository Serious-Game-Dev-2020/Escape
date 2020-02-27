using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove2 : MonoBehaviour
{
    public GameObject character;
    public Rigidbody charaRigidbody;
    public int moveSpeed;
    Animator moveCharacter;
    // Start is called before the first frame update
    void Start()
    {
        moveCharacter = character.GetComponent<Animator> ();
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
            
            charaRigidbody.velocity = new Vector3(-horizontal * moveSpeed, charaRigidbody.velocity.y, charaRigidbody.velocity.z);
            Debug.Log("平移");
        }

        if(horizontal > 0)

        {
            RunFront();
        }

        if(horizontal < 0)

        {
            RunBack();
        }

         else if(horizontal == 0 && vertical == 0)
        {
            charaRigidbody.velocity = Vector3.zero;
        }
    }
     void VerticalMove(float vertical)
    {
        if(vertical != 0)
        {
            charaRigidbody.velocity = new Vector3(charaRigidbody.velocity.x, charaRigidbody.velocity.y, -vertical * moveSpeed);
        }
    }
    void RunFront()
    {
       moveCharacter.SetBool("RunFront", true);
    }
    void RunBack()
    {
       moveCharacter.SetBool("RunBack", true);
    }
    void InCell()
    {
      moveCharacter.SetBool("InCell", true);
    }
    void Pull()
    {
      moveCharacter.SetBool("Pull", true);
    }
}
