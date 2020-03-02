using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    //public GameObject centralOb;
   // public float speed;
    public bool Timetimetime = false;
    public float timer = 0.0f;
    MoveBool[] mb;
    //private int timeCount = 0;
    public bool Go = false;
    public bool Back = false;
    //public GameObject[] door = new GameObject[3];
    public GameObject centralOb;
    float speed = 8.0f;
    void Start()
    {
        mb = FindObjectsOfType<MoveBool>();
        if (centralOb == null)
        {
            centralOb = GameObject.FindGameObjectWithTag("CenterObject");
        }
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "Prison")
        {
           
                Timetimetime = true;
                Debug.Log("pengdaole");
                //timer += Time.deltaTime;
                // Door();
          
        }
     }
    void Update()
    {
        //Debug.Log("pengdaole");
        if (Timetimetime == true)
        {
            timer += Time.deltaTime;
            Door();
        }
        GoBack();
    }

    void Door()
    {
        if (timer >= 0)
        {
            //foreach (MoveBool b in mb)
            {
                Go = true;
            }
            //Debug.Log("stop");
        }
        if (timer >= 1.5)
        {
            //foreach (MoveBool b in mb)
            {
                Go = false;
            }
            //Debug.Log("stop");
        }
        if (timer >= 3.5)
        {
            //foreach (MoveBool b in mb)
            {
                Back = true;
            }
            //Debug.Log("go");
        }
        if (timer >= 5)
        {
            //foreach (MoveBool b in mb)
            {
                Back = false;
                timer = 0;
                Timetimetime = false;
            }
            // Debug.Log("go");
        }
    }
    void GoBack()
    {
        if (Go == true)
        {
            transform.RotateAround(centralOb.transform.position, Vector3.down, speed * Time.deltaTime);
        }
        if (Back == true)
        {
            transform.RotateAround(centralOb.transform.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}
