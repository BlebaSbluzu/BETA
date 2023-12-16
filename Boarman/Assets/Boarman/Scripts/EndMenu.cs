using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using TMPro;
public class EndMenu : MonoBehaviour
{
    
public static String DeathTextString;
    public TMP_Text DeathText;

    

void OnCollisionEnter(Collision collision)
{


if (collision.gameObject.tag == "Player")
{
SceneManager.LoadScene(1);
DeathTextString = "You crashed";
DeathText.SetText("You crashed");
Timer.TimeUsed = 0;
}

}
 public void RestartGame(){
   Timer.TimeUsed = 0;
FuelMeter.fuel = 100;
PlayerController.speed = 15;
    SceneManager.LoadScene(1);
    DeathTextString="dsb";
 }
}