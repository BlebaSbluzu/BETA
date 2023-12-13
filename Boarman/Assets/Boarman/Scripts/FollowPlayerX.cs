using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayerX : MonoBehaviour
{
    // Define the car object as a variable  
     public GameObject Car;



        // The consistent offest we want to keep from the car 
    private Vector3 offset = new Vector3(0,6,-8.5f);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.position = Car.transform.position + offset;

    }
}
