using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public SpriteRenderer emote;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.x > 2.8 && pos.y > 0.5)
        {
            emote.enabled = true;
        } else
        {
            emote.enabled = false;
        }
    }
    public void moveUp()
    {
        Vector2 pos = transform.position;
        pos.y += speed;
        transform.position = pos;
    }

   public void moveDown()
    {
        Vector2 pos = transform.position;
        pos.y -= speed;
        transform.position = pos;
    }

   public void moveLeft()
    {
        Vector2 pos = transform.position;
        pos.x -= speed;
        transform.position = pos;
    }

   public void moveRight()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        transform.position = pos;
    }
}
