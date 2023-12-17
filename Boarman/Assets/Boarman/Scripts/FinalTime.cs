using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class FinalTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] TextMeshProUGUI timerText;

    public float time;

    // Update is called once per frame
    void Update()
    {
    bool generatescore = PlayerController.generatescore;


if(generatescore == true){
     time = Timer.TimeUsed;

setScore();
       


}

void setScore(){
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.SetText(string.Format("Time: {0:00}:{1:00}",minutes,seconds));
        generatescore = false;
}
    }
}
