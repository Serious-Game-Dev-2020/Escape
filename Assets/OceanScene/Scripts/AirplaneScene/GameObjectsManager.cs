using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsManager : MonoBehaviour
{
    public GameObject Character;
    public GameObject airPlane;
    public GameObject[] burden = new GameObject[3];
    public ParticleSystem[] parS = new ParticleSystem[8];
    public GameObject[] burdens = new GameObject[6];

    public ParticleSystem[] parSs = new ParticleSystem[8];
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] burden = GameObject.FindGameObjectsWithTag("Burden");
        //ParticleSystem[] parS = GameObject.particleSystem.FindGameObjectsWithTag("Particles");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
