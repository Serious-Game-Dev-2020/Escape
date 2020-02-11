using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlright : MonoBehaviour
{
    // Start is called before the first frame update
   public Animator leftLeg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartLeftLeg();
    }
    void StartLeftLeg()
    {
        leftLeg.SetTrigger("MoveLeftLeg");
        
        
    }
}
