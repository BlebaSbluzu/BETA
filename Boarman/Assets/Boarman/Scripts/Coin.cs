using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin: MonoBehaviour
{
    // Start is called before the first frame update
   public float turnSpeed = 90f;
   private void OnTriggerEnter(Collider other)
   {
if(other.gameObject.GetComponent<Obstacle>() != null)
{
Destroy(gameObject);
return;
}

if (other.gameObject.name != "Player"){
    return;
}
Destroy(gameObject);

if(FuelMeter.fuel + 5>= 100){

}
else{FuelMeter.fuel = FuelMeter.fuel + 5;}

   }
   

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


}
