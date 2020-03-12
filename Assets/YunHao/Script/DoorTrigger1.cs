using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger1 : MonoBehaviour
{
    RotateAround RotateAround;
    public bool triggerCondition = false;
 public static bool triggerCondition2 = false;

    public Animator charaAnimator;
    void Start()
    {
        RotateAround = FindObjectOfType<RotateAround>();
    }

 // Update is called once per frame
    void Update2()
    {
  // 非static
  DoorTrigger t1 = new DoorTrigger();
  t1.triggerCondition = true;
  
  DoorTrigger t2 = new DoorTrigger();
  t2.triggerCondition = true;
  
  
  // static
  DoorTrigger1.triggerCondition2 = true;
  // static
  DoorTrigger1.triggerCondition2 = false;
  
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