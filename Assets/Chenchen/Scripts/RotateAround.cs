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
    void Start()
    {
        mb = FindObjectsOfType<MoveBool>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Timetimetime = true;
            Debug.Log("pengdaole");
            //timer += Time.deltaTime;
           // Door();
        }
       

        

    }
    public void Update()
    {
        if (Timetimetime == true)
        {
            timer += Time.deltaTime;
            Door();
        }

    }
    void Door()
    {
        if (timer >= 0)
        {
            foreach (MoveBool b in mb)
            {
                b.Go = true;
            }
            //Debug.Log("stop");
        }
        if (timer >= 1.5)
        {
            foreach (MoveBool b in mb)
            {
                b.Go = false;
            }
            //Debug.Log("stop");
        }
        if (timer >= 3.5)
        {
            foreach (MoveBool b in mb)
            {
                b.Back = true;
            }
            //Debug.Log("go");
        }
        if (timer >= 5)
        {
            foreach (MoveBool b in mb)
            {
                b.Back = false;
            }
            // Debug.Log("go");
        }
    }
   
}
