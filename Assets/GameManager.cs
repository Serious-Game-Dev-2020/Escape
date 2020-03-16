using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance = null;
  

   public GameObject chapter1;
   public GameObject chapter2;
   public GameObject chapter3;
   public GameObject chapter4;


   enum Chapternumber{chapter1,chapter2,chapter3,chapter4}
   Chapternumber chapter;

   void Start()
   {
       chapter = Chapternumber.chapter1;
       //change the transparance of the chapter picture
   }
   void Awake() 
   {
       if (instance == null){
           instance = this;
       }

       else if (instance != this){

           Destroy(gameObject);
       }

       DontDestroyOnLoad(gameObject);
       Init();
   } 

   public void Init(){
       PlayerPrefs.GetString("CurrentChapterNumber");
       SceneManager.LoadScene("Final3.0");
       SceneManager.LoadScene("WindScene");

   }
   public void nothing(){}

   

   
    
}
