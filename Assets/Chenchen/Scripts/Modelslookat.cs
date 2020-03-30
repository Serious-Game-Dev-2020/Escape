using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelslookat : MonoBehaviour
{
    public Transform target;
    public bool La = false;

    void Update()
    {
        if (La==true) {
            Debug.Log("lookat");
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.LookAt(targetPosition);
        }
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box002_105" )
        {
            Debug.Log("hiii");
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.LookAt(targetPosition);
        }
    }*/
}
