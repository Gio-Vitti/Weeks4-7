using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWater : MonoBehaviour
{
    public GameObject water;
    public GameObject meter;
   


    //Spawns water droplet when watering can is clicked and resets timer
    public void spawnWater()
    {
       Instantiate(water);
        meter.GetComponent<WaterTimer>().moist = 0;
    }
}
