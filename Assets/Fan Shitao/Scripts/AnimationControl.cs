using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlLeft : MonoBehaviour
{
    
    public Animator rightLeg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartRightLeg();
    }
    void StartRightLeg()
    {
        rightLeg.SetTrigger("MoveRightLeg");
        
        
    }


}
