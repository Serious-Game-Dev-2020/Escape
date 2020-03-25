using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static GameManager instance = null;
  
   int level1, level2, level3, level4;

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
       level1 = PlayerPrefs.GetInt("level1", 0);
       level2 = PlayerPrefs.GetInt("level2", 0);
       level3 = PlayerPrefs.GetInt("level3", 0);
       level4 = PlayerPrefs.GetInt("level4", 0);

       if (level1 == 1) {
           chapter1.SetActive(true);
       } else {
           chapter1.SetActive(false);
       }
       if (level2 == 1) {
           chapter2.SetActive(true);
       } else {
           chapter2.SetActive(false);
       }
   }

   public void Chapter1Active(int isActive = 0) {
       PlayerPrefs.SetInt("level1", isActive);
        if (isActive == 1) {
           chapter1.SetActive(true);
       } else {
           chapter1.SetActive(false);
       }
       
   }

    public void Chapter2Active(int isActive = 0) {
       PlayerPrefs.SetInt("level2", isActive);
        if (isActive == 1) {
           chapter1.SetActive(true);
       } else {
           chapter1.SetActive(false);
       }
       
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
       //Init();
   } 

//    public void Init(){
//        PlayerPrefs.GetString("CurrentChapterNumber");
//        SceneManager.LoadScene("Final3.0");
//        SceneManager.LoadScene("WindScene");

//    }
//    public void nothing(){}

   public void LoadScene(string name) {
       SceneManager.LoadScene(name);
   }

   
    
}
