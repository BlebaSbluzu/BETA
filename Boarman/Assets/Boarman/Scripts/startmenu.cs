using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{

   public static int LEVEL;
    // Start is called before the first frame update
   public void startGame(){
// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
SceneManager.LoadScene(1);

Debug.Log(SceneManager.GetActiveScene().buildIndex + 1 + "\n");

LEVEL = 1;
FuelMeter.fuel = 100;
PlayerController.speed = 15;

   }

      public void startGame2(){
// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
SceneManager.LoadScene(2);

Debug.Log(SceneManager.GetActiveScene().buildIndex + 2 + "\n");
LEVEL = 2;
FuelMeter.fuel = 100;
PlayerController.speed = 15;

   }
   
public void Reset(){

SceneManager.LoadScene(0);

}


}
