using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarchRightLeg : MonoBehaviour
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
        neighbour = GameObject.FindWithTag("Neighbour").transform;
        parent = GameObject.FindWithTag("Parent").transform;
        
    }

   
    void MarchBack()
    {
        if (Input.GetKey(KeyCode.D))

        {
        
        leftLeg.SetBool("Back",true);
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

        if (Input.GetKeyUp(KeyCode.D))
        
        {
        
        leftLeg.SetBool("Back",false);
        // march.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

        MarchBack();
    }

        
}