using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMovement : MonoBehaviour
{
    public GameObject tank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        

        if(tank.GetComponent<TankController>().invert == false)
        {
            transform.right = direction;
        } else
        {
            transform.right = -direction;
        }
    }
}
