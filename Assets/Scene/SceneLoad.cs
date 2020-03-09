using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneLoad : MonoBehaviour
{
    GameManager gameManager;
    void Start() {

        gameManager = GameManager.instance;
        ChapterChoose();
    }
    //condition to chapterchange
    void OnMouseDown(){
        ChapterChoose();
         //   GetComponent<Renderer>().material.color=chapter.chapter1;
    }
    void ChapterChoose()
   {
       switch(gameManager.chapter){
       case Chapternumber.chapter1:
          //   GetComponent<Renderer>().material.color=chapter.chapter1;
            break;
       case Chapternumber.chapter2:

            break;
       case Chapternumber.chapter3:

            break;
       case Chapternumber.chapter4:

            break;

           
       }
   }
    
}
