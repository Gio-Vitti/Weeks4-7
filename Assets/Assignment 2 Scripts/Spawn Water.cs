using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWater : MonoBehaviour
{
    public GameObject water;

    //Spawns water droplet when watering can is clicked
    public void spawnWater()
    {
       Instantiate(water);
    }
}
