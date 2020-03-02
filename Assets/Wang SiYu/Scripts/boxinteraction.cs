using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxinteraction : MonoBehaviour
{
    AudioSource myAudio;
    public AudioClip myClip1;
    public GameObject redSphere;



    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Redround")
        {
            Debug.Log("111");
            myAudio.clip = myClip1;
            myAudio.Play();

        }






    }

}

