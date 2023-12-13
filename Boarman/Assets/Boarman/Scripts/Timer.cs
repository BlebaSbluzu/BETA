using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    public static float TimeUsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeUsed += Time.deltaTime;
        int minutes = Mathf.FloorToInt(TimeUsed / 60);
        int seconds = Mathf.FloorToInt(TimeUsed % 60);
        timerText.text = string.Format("Timer: {0:00}:{1:00}",minutes,seconds);
    }
}
