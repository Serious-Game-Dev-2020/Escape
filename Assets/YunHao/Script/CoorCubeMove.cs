using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CoorCubeMove : MonoBehaviour
{
    public PathCreator pathCreator;
    public PathCreator pathCreator2;
    public float moveSpeed = 0.1f;
    public float horizontalDistance;
    public GameObject coorCube;
    public Rigidbody cubeRigidbody;
    public Animator charaAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
    //VerticalMove(Input.GetAxis("Horizontal"));
    }
    void HorizontalMove(float horizontal, float vertical)
    {
        if(horizontal != 0)
        {
            charaAnimator.SetBool("Run", true);
            horizontalDistance += moveSpeed * horizontal;
            coorCube.transform.position = pathCreator.path.GetPointAtDistance(horizontalDistance);
            coorCube.transform.rotation = pathCreator.path.GetRotationAtDistance(horizontalDistance);
            if (horizontalDistance <= 0.2f )
            {
                horizontalDistance = 0.2f;
            }
                //cubeRigidbody.velocity = new Vector3(cubeRigidbody.velocity.x, cubeRigidbody.velocity.y, -horizontal * moveSpeed);
                //Debug.Log("平移");
        }
        else
        {
            if(vertical == 0)
            {
                charaAnimator.SetBool("Run", false);
                cubeRigidbody.velocity = Vector3.zero;
            }
        }
    }
}
