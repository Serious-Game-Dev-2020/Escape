using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplanesController : MonoBehaviour
{
    GameObjectsManager gameObjectsManager;

    Rigidbody[] airRigidbody = new Rigidbody[9];
    //GameObject[] airPlane = new GameObject[9];

    int i;
    public GameObject[] airPlane;
    public int fallSpeed = 5;
    //GameObject[] airPlane = GameObject.FindGameObjectsWithTag("Airplanes");
    void Start()
    {
        gameObjectsManager = FindObjectOfType<GameObjectsManager>();
        /*foreach (Transform child in gameObjectsManager.airPlane.transform)
        {
            airRigidbody[] 
            //Debug.Log(gameObjectsManager.airPlane.name);
            Debug.Log(child.gameObject.name);
        }*/
       // GameObject[] airPlane = GameObject.FindGameObjectsWithTag("Airplanes");

        //GameObject[] burden = GameObject.FindGameObjectsWithTag("Burden");

        for (int i = 0; i < airPlane.Length; i++)
        {
           airRigidbody[i] = airPlane[i].GetComponent<Rigidbody>();
           Debug.Log(airPlane[i].name);
        }
        //Rigidbody[] airRigidbody = airPlane[].GetComponent<Rigidbody>();
        //Debug.Log(airPlane[0].name);
    }

    void Update()
    {
        if (Time.frameCount % fallSpeed == 0)
        {
            Fall();
        }
        //Back();
    }

    void Fall()
    {
        i = Random.Range(0,9);
        airRigidbody[i].AddForce(Vector3.down * 7000f, ForceMode.Force);
        //airRigidbody[i].AddForce(Vector3.down * (7000f + 2000f * Time.deltaTime), ForceMode.Force);
    }

    void Back()
    {
        if(airRigidbody[i].position.y <= 156.0f)
        {
            airRigidbody[i].position = new Vector3(airRigidbody[i].position.x, 200.4f ,airRigidbody[i].position.z);
            airRigidbody[i].velocity = new Vector3(0.0f, 0.0f, 0.0f);
            //gameObjectsManager.parS[i].Play();
        }
        /*else if(airRigidbody[i].position.y <= 40.0f)
        {
            gameObjectsManager.parS[i].Play();
        }*/
    }
    /*private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Ocean")
        {
            airRigidbody[i].position = new Vector3(airRigidbody[i].position.x, 200.4f ,airRigidbody[i].position.z);
            airRigidbody[i].velocity = new Vector3(0.0f, 0.0f, 0.0f);
            Debug.Log("CharacterTrigger");
        }
        /*else if(collision.tag == "Shadows")
        {
            gameObjectsManager.parS[i].Play();
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
            airRigidbody[i].position = new Vector3(airRigidbody[i].position.x, 200.4f ,airRigidbody[i].position.z);
            airRigidbody[i].velocity = new Vector3(0.0f, 0.0f, 0.0f);
            Debug.Log("ColliderOcean");
        /*else if(collision.tag == "Shadows")
        {
            gameObjectsManager.parS[i].Play();
        }*/
    }
}
