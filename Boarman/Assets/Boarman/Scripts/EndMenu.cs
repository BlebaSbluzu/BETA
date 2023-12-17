using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
// using UnityEditor.PackageManager;

public class EndMenu : MonoBehaviour
{
    

    public TMP_Text deathText;

void OnCollisionEnter(Collision collision)
{


if (collision.gameObject.tag == "Player")
{
SceneManager.LoadScene(7);
// DeathText.DeathTextString = "You crashed";
deathText.SetText("You Crashed");
Timer.TimeUsed = 0;
}

}


 
 public void RestartGame(){
   Timer.TimeUsed = 0;
FuelMeter.fuel = 100;
PlayerController.speed = 15;

    int level;
    if(startmenu.LEVEL == 1){
        level = 2;
    }
    else{
        level = 5;
    }
    SceneManager.LoadScene(level);

 }


}