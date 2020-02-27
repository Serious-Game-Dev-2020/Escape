using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    GameObjectsManager gameObjectsManager;
    Rigidbody characterRigidbody;
    public float moveSpeed = 40.0f;
    public int burdenShow = 0;
    int burdenHide;
    private bool  countStatus;  //是否开始计时
    private float CountDown; //倒计时
    private float CountPress;
    public ParticleSystem pars;
    public Renderer Rder;
    void Start()
    {
        gameObjectsManager = FindObjectOfType<GameObjectsManager>();
        characterRigidbody = gameObjectsManager.Character.GetComponent<Rigidbody>();
        //Debug.Log(gameObjectsManager.burden[2].name);
    }

    void Update()
    {
        HorizontalMove(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        VerticalMove(Input.GetAxis("Vertical"));
        BreakFree();
        ShowBurden();
        limitation();
    }
    void HorizontalMove(float horizontal, float vertical)
    {
        if(horizontal != 0)
        {
            characterRigidbody.velocity = new Vector3(characterRigidbody.velocity.x, characterRigidbody.velocity.y, horizontal * moveSpeed);
            //Debug.Log("平移");
        }
        else if(horizontal == 0 && vertical == 0)
        {
            characterRigidbody.velocity = Vector3.zero;
        }
    }
    void VerticalMove(float vertical)
    {
        if(vertical != 0)
        {
            characterRigidbody.velocity = new Vector3(-vertical * moveSpeed, characterRigidbody.velocity.y, characterRigidbody.velocity.z);
            //Debug.Log("进退");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Airplanes")
        {
            //Debug.Log(gameObjectsManager.burden[0].name);
            //cDebug.Log("BurdenTrigger");
            //gameObjectsManager.burden[0].SetActive(false);
            
            //gameObjectsManager.burden[burdenShow].SetActive(true);
            burdenShow++;
            moveSpeed -= 10.0f;
            //Debug.Log(gameObjectsManager.burden[burdenShow]);
        }
    }
    private void BreakFree()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Rder.material.EnableKeyword("_EMISSION");
            if (CountDown == 0)
            {
                CountDown = Time.time; 
                countStatus  = true;       
                CountPress++; 
            }
            else if(CountDown != 0 && CountPress >=1)
            {
                //Application.Quit();
                Debug.Log("BreakFree");
                //gameObjectsManager.burden[burdenShow].SetActive(false);
                burdenShow--;
                Rder.material.color = Color.green;
                moveSpeed += 10.0f;
                CountPress = 0;
            }
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            Rder.material.DisableKeyword("_EMISSION");
        }

        if (countStatus)
        {
            if ((Time.time - CountDown) > 2)
            {
                CountDown = 0;
                countStatus  = false;
            }
        }
    }
    void ShowBurden()
    {
        if(burdenShow == 0)
        {
            gameObjectsManager.burden[0].SetActive(false);
            gameObjectsManager.burden[1].SetActive(false);
            gameObjectsManager.burden[2].SetActive(false);
        }
        if(burdenShow == 1)
        {
            gameObjectsManager.burden[0].SetActive(true);
            gameObjectsManager.burden[1].SetActive(false);
            gameObjectsManager.burden[2].SetActive(false);
        }
        if(burdenShow == 2)
        {
            gameObjectsManager.burden[0].SetActive(true);
            gameObjectsManager.burden[1].SetActive(true);
            gameObjectsManager.burden[2].SetActive(false);
        }
        if(burdenShow == 3)
        {
            gameObjectsManager.burden[0].SetActive(true);
            gameObjectsManager.burden[1].SetActive(true);
            gameObjectsManager.burden[2].SetActive(true);
        }
    }
    void limitation()
    {
        if(burdenShow>3)
        {
            burdenShow = 3;
        }
        else if(burdenShow < 0)
        {
            burdenShow = 0;
        }
        if(moveSpeed<=10.0f)
        {
            moveSpeed=10.0f;
        }
        else if(moveSpeed>=40.0f)
        {
            moveSpeed = 40.0f;
        }
    }
    
}
