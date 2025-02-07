using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiMovement : MonoBehaviour
{
    Vector2 pos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
        //Left Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x = pos.x - speed;
        }
        //Right Movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x = pos.x + speed;
        }
        //Down Movement
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y = pos.y - speed;
        }
        //Up Movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y = pos.y + speed;
        }
    } //
}
