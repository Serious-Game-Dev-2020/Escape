using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBool1 : MonoBehaviour
{
    public bool Go = false;
    public bool Back = false;
    public GameObject centralOb;
    public float speed;

    void Update()
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
