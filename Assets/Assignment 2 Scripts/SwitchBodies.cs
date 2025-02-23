using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBodies : MonoBehaviour
{
    public int body = 1;

    public GameObject body1;
    public GameObject body2;
    public GameObject body3;
    public GameObject body4;
    public GameObject body5;
    public GameObject body6;
    public GameObject body7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Reset body variable
        if (body >= 8)
        {
            body = 1;
        }
        else if (body <= 0)
        {
            body = 7;
        }

        //Show corresponding body sprites:
        //Body 1
        if (body == 1)
        {
            body1.GetComponent<SpriteRenderer>().enabled = true;
        } else { body1.GetComponent<SpriteRenderer>().enabled = false;}

        //Body 2
        if (body == 2)
        {
            body2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body2.GetComponent<SpriteRenderer>().enabled = false; }

        //Body 3
        if (body == 3)
        {
            body3.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body3.GetComponent<SpriteRenderer>().enabled = false; }

        //Body 4
        if (body == 4)
        {
            body4.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body4.GetComponent<SpriteRenderer>().enabled = false; }

        //Body 5
        if (body == 5)
        {
            body5.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body5.GetComponent<SpriteRenderer>().enabled = false; }

        //Body 6
        if (body == 6)
        {
            body6.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body6.GetComponent<SpriteRenderer>().enabled = false; }

        //Body 7
        if (body == 7)
        {
            body7.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { body7.GetComponent<SpriteRenderer>().enabled = false; }
    }

    //Change body variable with Right Arrow button 
    public void bodyUp()
    {
        body += 1;
    }

    //Change body variable with Left Arrow button 
    public void bodyDown()
    {
        body -= 1;
    }
}
