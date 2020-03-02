using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class LightCollider7 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5f;
    public float distanceTravelled;
    public float MoveSpeed;
    AudioSource myAudio;
    public AudioClip myClip1;

    private void Start()
    {
        MoveSpeed = 5.0f;
        myAudio = GetComponent<AudioSource>();

    }



    //Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))

        //if (Input.GetKey(KeyCode.C))
        //{
            /*if(distanceTravelled <= 22.0f && distanceTravelled >= 0.0f)
            {
            //distanceTravelled += speed * Time.deltaTime;
            }*/
            if(distanceTravelled > 22.0f)
            {
                speed = -speed;
            }
            else if(distanceTravelled < 0.0f)
            {
                speed = -speed;
            }
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



