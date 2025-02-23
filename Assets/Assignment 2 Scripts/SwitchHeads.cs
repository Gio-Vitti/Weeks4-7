using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHeads : MonoBehaviour
{
    public int head = 1;

    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject head4;
    public GameObject head5;
    public GameObject head6;
    public GameObject head7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Reset head variable
        if (head == 8)
        {
            head = 1;
        } else if (head == 0) {
            head = 7;
        }

        //Show corresponding head sprites:
        //head 1
        if (head == 1)
        {
            head1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head1.GetComponent<SpriteRenderer>().enabled = false; }

        //head 2
        if (head == 2)
        {
            head2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head2.GetComponent<SpriteRenderer>().enabled = false; }

        //head 3
        if (head == 3)
        {
            head3.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head3.GetComponent<SpriteRenderer>().enabled = false; }

        //head 4
        if (head == 4)
        {
            head4.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head4.GetComponent<SpriteRenderer>().enabled = false; }

        //head 5
        if (head == 5)
        {
            head5.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head5.GetComponent<SpriteRenderer>().enabled = false; }

        //head 6
        if (head == 6)
        {
            head6.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head6.GetComponent<SpriteRenderer>().enabled = false; }

        //head 7
        if (head == 7)
        {
            head7.GetComponent<SpriteRenderer>().enabled = true;
        }
        else { head7.GetComponent<SpriteRenderer>().enabled = false; }
    }

    //Change head variable with Right Arrow button 
    public void headUp()
    {
        head += 1;
    }

    //Change head variable with Left Arrow button 
    public void headDown()
    {
        head -= 1;
    }
}

