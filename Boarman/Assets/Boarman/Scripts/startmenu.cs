using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void startGame(){
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
FuelMeter.fuel = 100;
PlayerController.speed = 15;

   }
}
