using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public GameObject airPlane;
    public Rigidbody airRig;
    public ParticleSystem parS;
    // Start is called before the first frame update
    void Start()
    {
        airRig.velocity = new Vector3(-100.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //airRig.velocity = new Vector3(10.0f, 0.0f, 0.0f);
        //airPlane.transform.position += Vector3.left  * 2.0f;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Ocean")
        {
            airRig.position = new Vector3(airRig.position.x, 200.4f ,airRig.position.z);
            airRig.velocity = new Vector3(-100.0f, 0.0f, 0.0f);
            //Debug.Log("ColliderOcean");
            parS.Play();
        }
        if(collision.tag == "Character")
        {
            airRig.position = new Vector3(airRig.position.x, 200.4f ,airRig.position.z);
            airRig.velocity = new Vector3(-100.0f, 0.0f, 0.0f);
            Debug.Log("ColliderCharacter");
        }
    }
}
