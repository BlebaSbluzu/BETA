using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{

   public static int LEVEL;
    // Start is called before the first frame update

    public void startgameTUD(){
      SceneManager.LoadScene(1);
    }
   public void startGame(){
<<<<<<< HEAD
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
SceneManager.LoadScene(2);
=======
// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
SceneManager.LoadScene(1);

Debug.Log(SceneManager.GetActiveScene().buildIndex + 1 + "\n");
>>>>>>> main

LEVEL = 1;
FuelMeter.fuel = 100;
PlayerController.speed = 15;

   }
   public void startgameNothern(){
      SceneManager.LoadScene(3);
   }

      public void startGame2(){
<<<<<<< HEAD
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
SceneManager.LoadScene(4);
=======
// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
SceneManager.LoadScene(2);
>>>>>>> main

LEVEL = 2;
FuelMeter.fuel = 100;
PlayerController.speed = 15;

   }
   
public void Reset(){

SceneManager.LoadScene(0);

}


}
