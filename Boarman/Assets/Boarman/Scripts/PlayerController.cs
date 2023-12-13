using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    bool alive = true;

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
        return speed;
    }
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (!alive) return;
    }
    private void LateUpdate()
    {
        if (transform.position.y < -5)
        {
          SceneManager.LoadScene(2)   ;
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speedHandler() * Time.deltaTime);

        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime * horizontalInput);


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
   
   
   
//     public TextMeshProUGUI gameOverText;
// public Button restartButton; 
// public bool isGameActive;



// public void GameOver()
//     {
//         gameOverText.gameObject.SetActive(true);
//         restartButton.gameObject.SetActive(true);
//         isGameActive = false;
//     }

//     // Restart game by reloading the scene
//     public void RestartGame()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//         Debug.Log("penis");
//     }

// }
