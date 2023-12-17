using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Numerics;

public class PlayerController : MonoBehaviour
{

// public static UnityEngine.Vector3 Player;

    bool alive = true;


    public static bool generatescore = false;
    private float turnspeed = 45.0f;
    private float horizontalInput;


    public static int speed = 15;
    public int speedHandler()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            
            if (speed == 50)
            {
                speed = 50;
            }
            else
            {
                speed += 5;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (speed == 15)
            {
                speed = 15;
            }
            else
            {
                speed -= 5;
            }
        }
        Debug.Log(speed);
        print(gameObject.name);
        return speed;
    }
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (!alive) return;
    }
    private void LateUpdate()
    {
        if (transform.position.y < -3)
        {
          SceneManager.LoadScene(7)   ;
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(UnityEngine.Vector3.forward * speedHandler() * Time.deltaTime);

        transform.Rotate(UnityEngine.Vector3.up * turnspeed * Time.deltaTime * horizontalInput);


if(GroundSpawner.showEnd == true){
}

    if (transform.position.z >= GroundSpawner.EndPoint.z+10){


        if(startmenu.LEVEL ==1){
        SceneManager.LoadScene(3);
generatescore = true;
        }
        else{
        SceneManager.LoadScene(6);
generatescore = true;
        }

        

    }

    }

 public void Die()
    {
        alive = false;

       Invoke ("Restart", 0);
    }
    void Restart(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    }
   
   
