using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    RotateAround RotateAround;// = new RotateAround();
    public bool triggerCondition = false;
    //public Animator charaAnimator;
    void Start()
    {
        RotateAround = FindObjectOfType<RotateAround>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && triggerCondition == true)
            {
                Debug.Log("DoorTrigger");
                //foreach(RotateAround R in RotateAround)
                //{
                RotateAround.Timetimetime = true;
                //}
                //RotateAround.Timetimetime = true;
                //charaAnimator.SetBool("PullTheDoor", true);
            }
        /*if (Input.GetKeyUp(KeyCode.H))
        {
            //charaAnimator.SetBool("PullTheDoor", false);
        }*/
    }
    void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.name == "ThirdPersonController")
        {
            triggerCondition = true;
        }
    }
    void OnTriggerExit(Collider collision) 
    {
        if(collision.gameObject.name == "ThirdPersonController")
        {
            triggerCondition = false;
        }
    }
}
