
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarchRightLeg : MonoBehaviour
{
    Animator leftLeg;
    Animation march;

    
    // Start is called before the first frame update
    void Start()
    {
        leftLeg = GetComponent<Animator>();
        march = GetComponent<Animation>();
        
    }

   
    void MarchBack()
    {
        if (Input.GetKey(KeyCode.D))

        {
        
        leftLeg.SetBool("Back",true);
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
