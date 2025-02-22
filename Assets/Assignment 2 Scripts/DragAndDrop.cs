using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool mouseHovering;

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

        //Check if the mouse is over the object
        if (mouse.x >= pos.x - size.x / 2 && mouse.x <= pos.x + size.x / 2 && mouse.y >= pos.y - size.y / 2 && mouse.y <= pos.y + size.y / 2)
        {
            mouseHovering = true;
        } else
        {
            mouseHovering = false;
        }

        //If the mouse is then clicked, mak object follow the cursor
        if (mouseHovering == true && Input.GetMouseButton(0))
        {
            transform.position = mouse;
        }
    }
    
}
