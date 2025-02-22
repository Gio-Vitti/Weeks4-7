using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    //Variables:
    //Detect when mouse is over object
    bool mouseHovering;

    //Follow mouse position
    bool followMouse;

    //Grow when placed into scene
    bool big;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Assign Vectors to transform
        Vector2 pos = transform.position;
        Vector2 size = transform.localScale;
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Check if the cursor is over the object and show transparent circle sprite
        if (mouse.x >= pos.x - size.x / 2 && mouse.x <= pos.x + size.x / 2 && mouse.y >= pos.y - size.y / 2 && mouse.y <= pos.y + size.y / 2)
        {
            mouseHovering = true;
            GetComponent<SpriteRenderer>().enabled = true;
        } else
        {
            mouseHovering = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }

        //If the mouse is then clicked, make object follow the cursor
        if (mouseHovering == true && Input.GetMouseButtonDown(0))
        {
           followMouse = true;
            big = true;
        }

        //When letting go of mouse, stop following the cursor
        if (Input.GetMouseButtonUp(0))
        {
            followMouse = false;
        }

        //Boolean variable to prevent the object from stopping if the ouse goes too fast
        if (followMouse == true)
        {
            transform.position = mouse;
        }

        if (big == true)
        {
            size.x = 3;
            size.y = 3;
        }

        transform.localScale = size;
    }
    
}
