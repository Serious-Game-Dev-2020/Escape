using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMoveLeft : MonoBehaviour
{
  
    Animator leftLeg;
    Animation march;

    
    // Start is called before the first frame update
    void Start()
    {
        leftLeg = GetComponent<Animator>();
        march = GetComponent<Animation>();
        
    }

    void MarchFront()
    {
        if (Input.GetKey(KeyCode.A))
        
        {
        leftLeg.SetBool("Front",true);
        
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
