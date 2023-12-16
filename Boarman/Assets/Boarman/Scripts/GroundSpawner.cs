
using UnityEngine;
using UnityEngine.UIElements;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundTile;
public int numberOfTilesToSpawn = 10;

  Vector3 nextSpawnPoint;
    private void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            SpawnTile();
        }
    }

    public void SpawnTile()
    {
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
