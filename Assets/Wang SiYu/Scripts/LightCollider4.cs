using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class LightCollider4 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    public float MoveSpeed;
    AudioSource myAudio;
    public AudioClip myClip1;
    public GameObject redSphere;


    private void Start()
    {
        MoveSpeed = 5.0f;
        myAudio = GetComponent<AudioSource>();

    }



    //Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))

        //if (Input.GetKey(KeyCode.J))
        //{

            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Character")
        {
            Debug.Log("111");
            myAudio.clip = myClip1;
            myAudio.Play();

        }

    }
}

    




