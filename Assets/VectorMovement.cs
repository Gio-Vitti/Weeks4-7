using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VectorMovement : MonoBehaviour
{
    public float speed;
    public float acceleration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;


    }
}
