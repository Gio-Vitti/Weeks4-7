using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMovement : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos.x = pos.x - speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos.x = pos.x + speed;
        }
    }
}
