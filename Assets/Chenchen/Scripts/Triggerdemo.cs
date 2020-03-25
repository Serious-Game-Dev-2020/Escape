using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerdemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == " Capsule") {
            Debug.Log("hi");
        }
    }
}
