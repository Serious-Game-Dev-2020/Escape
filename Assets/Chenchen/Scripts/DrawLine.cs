using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRenderer;

    public Transform origin;
    public Transform destination;
    public float lineDrawSpeed = 6f;
    public bool Lr = false;

    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
       // lineRenderer.SetPosition(0,origin.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Lr==true) {
            lineRenderer.SetPosition(0, origin.position);
            lineRenderer.SetPosition(1, destination.position); }
    }

   
}
