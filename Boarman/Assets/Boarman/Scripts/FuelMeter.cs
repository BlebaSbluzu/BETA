using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using UnityEngine.SceneManagement;


public class FuelMeter : MonoBehaviour
{
    


    public float CurrentTime = 5;
    public float MaxTime = 100;
    public TMP_Text FuelText;
    public Image FuelImage;

    public static float fuel;
    // Start is called before the first frame update
    void Start()
    {
    InvokeRepeating("CalculateFuel", 2f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        OutOfFuel();
    }


  void CalculateFuel()
    {
       int speed = PlayerController.speed;
       fuel = fuel-(speed/4);

    }

    public void UpdateUI(){
                // FuelImage.fillAmount = CurrentTime / MaxTime;
                FuelImage.fillAmount = fuel;
        FuelText.SetText("Fuel: " + fuel.ToString());

        // FuelText.SetText("Fuel: " + (CurrentTime / MaxTime).ToString());

    }



    public void OutOfFuel()
    {
        if (fuel <= 0)
        {
            // DeathText.DeathTextString = "You Ran out of Fuel";
            SceneManager.LoadScene(3);
            
            
        }
    }
}

