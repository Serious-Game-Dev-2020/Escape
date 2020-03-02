using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redinteractions : MonoBehaviour
{
    public float MoveSpeed;
    AudioSource myAudio;
    public AudioClip myClip1;
    public GameObject redSphere;

    private void Start()
    {
        MoveSpeed = 5.0f;
        myAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);

        }

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Redround")
        {
            Debug.Log("111");
            myAudio.clip = myClip1;
            myAudio.Play();

        }

    }*/
}

