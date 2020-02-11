using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlRight : MonoBehaviour
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
