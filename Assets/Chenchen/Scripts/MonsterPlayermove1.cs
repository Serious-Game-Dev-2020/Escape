using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPlayermove1 : MonoBehaviour
{
    Modelslookat Ml;
    void Start()
    {
        Ml = FindObjectOfType<Modelslookat>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box002_105")
        {
            Debug.Log("boom");
            Ml.La = true;
        }
        if (collision.gameObject.tag == "lookatno")
        {
            Debug.Log("boomdis");
            Ml.La = false;
        }
        }
}
