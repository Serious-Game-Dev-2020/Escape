using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    //private const float End = .45f;
    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public Transform origin;
    public Transform destination;
    public float lineDrawSpeed = 6f;

    public Transform[] Positions;
    //public  bool sheCondition = false;
    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0,origin.position);
 
        //dist = Vector3.Distance(origin.position ,destination .position );
    }

    // Update is called once per frame
    void Update()
    {

        //if(sheCondition == true)
        //{
        //sheXian();
        //}

        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetPosition(1, destination.position);
    }
   
}
