using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremovement : MonoBehaviour
{
    public float MoveSpeed;

    private void Start()
    {
        MoveSpeed = 5.0f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);

        }

    }
}
