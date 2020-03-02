using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTrigger : MonoBehaviour
{
    public RotateAround RotateAround;
    //public GameObject[] doorTrigger = new GameObject[3];
    public int[] doorSequece = new int[48];
    public int n;
    public GameObject[] doors;
    void Start()
    {
        //why there is something in this Array?
        if(doors != null)
        {
            doors = GameObject.FindGameObjectsWithTag("Door");
        }
        //doors = GameObject.FindGameObjectsWithTag("Door");
    }


    void Update()
    {
        RotateAround = FindObjectOfType<RotateAround>();
        if(Input.GetKeyDown(KeyCode.K))
        {
            RotateAround.Timetimetime = true;
            Debug.Log("Turn On");
        }
    }
    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Door" && collision.gameObject.GetComponent<RotateAround>() == null)
        {
            collision.gameObject.AddComponent<RotateAround>();
        }
    }
    void OnCollisionExit(Collision collision) 
    {
        if(collision.gameObject.tag == "Door")
        {
            if(RotateAround.Timetimetime == false)
            {
            //collision.gameObject.AddComponent<RotateAround>();
            Destroy(collision.gameObject.GetComponent<RotateAround>());
            }
        }
    }
}
