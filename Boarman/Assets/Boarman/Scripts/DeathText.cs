using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
using TMPro.Examples;
public class DeathText : MonoBehaviour
{
    
    
    public TMP_Text deathText;

    // Start is called before the first frame update
    void Start()
    {
        deathText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }


}
