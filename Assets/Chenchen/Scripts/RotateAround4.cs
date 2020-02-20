using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround4 : MonoBehaviour
{
    public bool Timetimetime = false;
    public float timer = 0.0f;
    MoveBool4[] mb4;
    //private int timeCount = 0;
    void Start()
    {
        mb4 = FindObjectsOfType<MoveBool4>();
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
            foreach (MoveBool4 b in mb4)
            {
                b.Go = true;
            }
            //Debug.Log("stop");
        }
        if (timer >= 1.5)
        {
            foreach (MoveBool4 b in mb4)
            {
                b.Go = false;
            }
            //Debug.Log("stop");
        }
        if (timer >= 3.5)
        {
            foreach (MoveBool4 b in mb4)
            {
                b.Back = true;
            }
            //Debug.Log("go");
        }
        if (timer >= 5)
        {
            foreach (MoveBool4 b in mb4)
            {
                b.Back = false;
            }
            // Debug.Log("go");
        }
    }
}
