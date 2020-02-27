using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    private float shake;
    public Renderer Rder;
    bool condition = true;
    int flickerSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        //BoxColliderClick = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*shake += Time.deltaTime;
        //Debug.Log(shake);
        //取余运算，结果是0到被除数之间的值
        //如果除数是1 1.1 1.2 1.3 1.4 1.5 1.6 
        //那么余数是0 0.1 0.2 0.3 0.4 0.5 0.6
        if(condition == true)
        {
            if (Time.frameCount % flickerSpeed == 0)
            {
                Rder.material.EnableKeyword("_EMISSION");
                //condition = false;
            }
            else
            {
                Rder.material.DisableKeyword("_EMISSION");
                //condition = false;
            }
        }*/
        if (Input.GetKeyDown(KeyCode.J))
        {
            Rder.material.EnableKeyword("_EMISSION");
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            Rder.material.DisableKeyword("_EMISSION");
        }
    }
    
}

