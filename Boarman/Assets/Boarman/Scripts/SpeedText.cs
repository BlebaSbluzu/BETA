using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text CurrentSpeed;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentSpeed.SetText("Current Speed: " + PlayerController.speed);
    }
}

