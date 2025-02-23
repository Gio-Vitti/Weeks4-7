using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDroplet : MonoBehaviour
{
    //Speed and water meter
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Makes water droplet fall
        Vector2 pos = transform.position;
        pos.y -= speed * Time.deltaTime;
       
        //Destroy itself when touching character
        if (pos.y < 0.5)
        {
            Destroy(gameObject);
        }
       
        transform.position = pos;
       
    }
}
