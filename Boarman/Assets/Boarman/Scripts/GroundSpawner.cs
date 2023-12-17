
using System;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;
using TMPro;
public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
public int numberOfTilesToSpawn = 10;

public static Boolean levelEnding = false;

int LevelLength = 16;



  Vector3 nextSpawnPoint;
  public static Vector3 EndPoint;
  public static bool showEnd = false;
    private void Start()
    {
        for (int i = 0; i < LevelLength; i++)
        {
            SpawnTile();
            
            if( i == LevelLength-2){

                levelEnding = true;

            }

            if(i == LevelLength-5){
                showEnd=true;
            }
        }
    }

    public void SpawnTile()
    {


            if(levelEnding == true){

        EndPoint = nextSpawnPoint;

        levelEnding = false;


    }


        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;




        // Decrease the number of tiles to spawn
        numberOfTilesToSpawn--;


        // Check if no more tiles need to be spawned
        if (numberOfTilesToSpawn == 0)
        {
            // Optional: You can disable further tile spawning or perform other actions here
            enabled = false; // Disable the script
        }
    
}


}
