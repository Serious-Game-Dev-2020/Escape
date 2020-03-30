using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigibody : MonoBehaviour
{
    internal static object position;

    void Update()
    {
        foreach (Rigidbody child in transform)
        {
            child.position += Vector3.left  * 2.0f;
            //Debug.Log("good");
            
            
        }
    }
}
