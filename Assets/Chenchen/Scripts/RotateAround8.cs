using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround8 : MonoBehaviour
{
    public bool Timetimetime = false;
    public float timer = 0.0f;
    MoveBool8[] mb8;
    //private int timeCount = 0;
    void Start()
    {
        mb8 = FindObjectsOfType<MoveBool8>();
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
            foreach (MoveBool8 b in mb8)
            {
                b.Go = true;
            }
            //Debug.Log("stop");
        }
        if (timer >= 1.5)
        {
            foreach (MoveBool8 b in mb8)
            {
                b.Go = false;
            }
            //Debug.Log("stop");
        }
        if (timer >= 3.5)
        {
            foreach (MoveBool8 b in mb8)
            {
                b.Back = true;
            }
            //Debug.Log("go");
        }
        if (timer >= 5)
        {
            foreach (MoveBool8 b in mb8)
            {
                b.Back = false;
            }
            // Debug.Log("go");
        }
    }
}
