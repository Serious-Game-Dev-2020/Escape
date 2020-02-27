using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    RotateAround RotateAround;
    public bool triggerCondition = false;
    public Animator charaAnimator;
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
                RotateAround.Timetimetime = true;
                charaAnimator.SetBool("PullTheDoor", true);
            }
        if (Input.GetKeyUp(KeyCode.H))
        {
            charaAnimator.SetBool("PullTheDoor", false);
        }
    }
    void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "Character")
        {
            triggerCondition = true;
        }
    }
}
