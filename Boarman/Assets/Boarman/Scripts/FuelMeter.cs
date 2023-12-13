using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class FuelMeter : MonoBehaviour
{
    


    public float CurrentTime = 5;
    public float MaxTime = 5;
    public TMP_Text FuelText;
    public Image FuelImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        
    }

    public void UpdateUI(){
                FuelImage.fillAmount = CurrentTime / MaxTime;
        FuelText.SetText("Fuel: " + (CurrentTime / MaxTime).ToString());
    }
}
