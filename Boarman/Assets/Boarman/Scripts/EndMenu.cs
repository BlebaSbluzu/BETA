using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    
void OnCollisionEnter(Collision collision)
{
if (collision.gameObject.tag == "Player")
{
SceneManager.LoadScene(1);
}

}
 public void RestartGame(){
    SceneManager.LoadScene(1);
 }
}