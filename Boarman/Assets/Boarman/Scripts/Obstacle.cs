using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{
    PlayerController playerMovement;
   private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
