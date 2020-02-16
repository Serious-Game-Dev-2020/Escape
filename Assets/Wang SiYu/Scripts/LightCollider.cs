using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class LightCollider : MonoBehaviour
{
    AudioSource myAudio;
    public AudioClip myClip1;
    public GameObject redSphere;
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    public float MoveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        MoveSpeed = 5.0f;
    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))

        if (Input.GetKey(KeyCode.E))
        {

            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        }
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

