
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GroundSpawner groundSpawner;
   
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
        
        SpawnCoins();
        if(startmenu.LEVEL ==2){
            SpawnObstacle();
        }
    }

    private void OnTriggerExit(Collider other)
    {
     
        Destroy(gameObject, 2);
    }
    private void Update()
    {
        
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
     int obstacleSpawnIndex = Random.Range(1, 4);

     Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

     Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
     
     public GameObject coinPrefab;

     void SpawnCoins()
     {
int coinsToSpawn = 1;
for (int i = 0; i< coinsToSpawn; i++){
    GameObject temp = Instantiate(coinPrefab, transform);
    temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());

}
     }

     Vector3 GetRandomPointInCollider (Collider collider)
     {
Vector3 point = new Vector3(
Random.Range(collider.bounds.min.x, collider.bounds.max.x),
Random.Range(collider.bounds.min.y, collider.bounds.max.y),
Random.Range(collider.bounds.min.z, collider.bounds.max.z)
);
if (point != collider.ClosestPoint(point))
{
point = GetRandomPointInCollider(collider);
}
point.y = 1;
return point;
     }
}

