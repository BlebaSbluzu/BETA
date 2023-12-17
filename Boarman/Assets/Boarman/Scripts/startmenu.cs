using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{

   public static int LEVEL;
   // Start is called before the first frame update

   public void Level1Story()
   {
      SceneManager.LoadScene(1);
   }


   public void startGame()
   {

      SceneManager.LoadScene(2);
      LEVEL = 1;
      FuelMeter.fuel = 100;
      PlayerController.speed = 15;
   }



   public void Level2Story()
   {
      SceneManager.LoadScene(4);
   }

   public void startGame2()
   {

      SceneManager.LoadScene(5);
      LEVEL = 2;
      FuelMeter.fuel = 100;
      PlayerController.speed = 15;
   }

   public void Reset()
   {

      SceneManager.LoadScene(0);

   }



   public void source(){
       Application.OpenURL("https://github.com/BlebaSbluzu/BETA.git");

   }

}
