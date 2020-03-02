using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteractions : MonoBehaviour
{
    AudioSource myAudio;
    public AudioClip myClip1;
    public GameObject redSphere;



    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Redsphere")
        {
            myAudio.clip = myClip1;
            myAudio.Play();

        }






    }

}
