using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround5 : MonoBehaviour
{
    public bool Timetimetime = false;
    public float timer = 0.0f;
    MoveBool5[] mb5;
    //private int timeCount = 0;
    void Start()
    {
        mb5 = FindObjectsOfType<MoveBool5>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Timetimetime = true;
            Debug.Log("pengdaole1");
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
            foreach (MoveBool5 b in mb5)
            {
                b.Go = true;
            }
            //Debug.Log("stop");
        }
        if (timer >= 1.5)
        {
            foreach (MoveBool5 b in mb5)
            {
                b.Go = false;
            }
            //Debug.Log("stop");
        }
        if (timer >= 3.5)
        {
            foreach (MoveBool5 b in mb5)
            {
                b.Back = true;
            }
            //Debug.Log("go");
        }
        if (timer >= 5)
        {
            foreach (MoveBool5 b in mb5)
            {
                b.Back = false;
            }
            // Debug.Log("go");
        }
    }
}
