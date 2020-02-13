using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMove : MonoBehaviour
{
    public GameObject movingpoint;
    public GameObject player;
    public float speed = 20f;
    public bool Smove = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Smove == true) {

             Moving();

         }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("zhuangplayer");
        transform.parent = player.transform;
       
    }
    void Moving()
    {
        transform.LookAt(movingpoint.transform);
        transform.position += transform.forward * 5f * Time.deltaTime;
    }
   
}
