using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{
    

    public TMP_Text deathText;

void OnCollisionEnter(Collision collision)
{


if (collision.gameObject.tag == "Player")
{
SceneManager.LoadScene(3);
// DeathText.DeathTextString = "You crashed";
deathText.SetText("You Crashed");
Debug.Log(  "\n" + startmenu.LEVEL + "\n");
Timer.TimeUsed = 0;
}

}



 public void RestartGame(){
   Timer.TimeUsed = 0;
FuelMeter.fuel = 100;
PlayerController.speed = 15;
    SceneManager.LoadScene(startmenu.LEVEL);

 }

// public void FuelText(){
//         if (FuelMeter.fuel <= 0)
//         {
//             // DeathText.DeathTextString = "You Ran out of Fuel";
//             deathText.SetText("You ran out of fuel");
            
            
//         }
//     }

// void LateUpdate(){
// FuelText();

// }

}