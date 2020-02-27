using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController1 : MonoBehaviour
{
    public GameObject Character;
    public Rigidbody charaRigidbody;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterVerticalMove(Input.GetAxis("Horizontal"));
        Limitation();
    }
    void CharacterVerticalMove(float vertical)
    {
        if(vertical != 0)
        {
            Character.transform.localPosition = new Vector3(Character.transform.localPosition.x + vertical * moveSpeed, Character.transform.localPosition.y, Character.transform.localPosition.z);
        }
    }
    void Limitation()
    {
        if(Character.transform.localPosition.x >= 0.4f)
        {
            Character.transform.localPosition = new Vector3(0.4f, Character.transform.localPosition.y, Character.transform.localPosition.z);
        }
        else if(Character.transform.localPosition.x <= -0.4f)
        {
            Character.transform.localPosition = new Vector3(-0.4f, Character.transform.localPosition.y, Character.transform.localPosition.z);
        }
    }
    /*private void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "TriggerBoxes")
        {
            Debug.Log("DoorTrigger");
        }
    }*/
}
