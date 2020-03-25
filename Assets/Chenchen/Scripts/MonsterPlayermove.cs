using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPlayermove : MonoBehaviour
{
    DrawLine Dl;
    public bool triggerCondition = false;
    void Start()
    {
        Dl = FindObjectOfType<DrawLine>();
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerCondition == true) {
           
            Dl.Lr =true;
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Box002_105")
        {
            Debug.Log("11111");
            triggerCondition = true;
        }
        /*if (other.gameObject.tag == "Capsule")
        {
            Debug.Log("11111");
            triggerCondition = true;
        }*/
    }
}

