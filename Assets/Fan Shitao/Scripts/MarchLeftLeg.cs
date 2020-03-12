using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarchLeftLeg : MonoBehaviour
{
  
    Animator leftLeg;
    Animation march;
    float lastTime;
    public Transform neighbour, parent;
    bool inSync = true;
    
    // Start is called before the first frame update
    void Start()
    {
        leftLeg = GetComponent<Animator>();
        march = GetComponent<Animation>();
        lastTime = Time.time;
        
    }

    void MarchFront()
    {
        if (Input.GetKey(KeyCode.A))
        
        {
            leftLeg.SetBool("Front",true);
            if ((Time.time - lastTime) < 2f) {
                Debug.Log("works");
               if (parent != null && neighbour != null) {
                    parent.position = new Vector3(parent.position.x, parent.position.y, neighbour.position.z);
                    lastTime = Time.time;
               }

            } else {
                inSync = false;
            }
        
        }

        if (Input.GetKeyUp(KeyCode.A))
        
        {
        leftLeg.SetBool("Front",false);
        
        // march.enabled=false;
        // leftLeg.GetComponent<Animator> ().Rebind ();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        MarchFront();
        
    }

        

}