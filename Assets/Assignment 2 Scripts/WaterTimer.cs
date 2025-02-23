using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTimer : MonoBehaviour
{
    public float moist;
    public GameObject eraseBody;
    public GameObject eraseHead;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Adds to timer every second
        moist += Time.deltaTime;
        GetComponent<Slider>().value = moist;

        //If the timer reaches its max value, disable Head and Body sprites
        if (moist >= GetComponent<Slider>().maxValue)
        {
            eraseHead.GetComponent<SwitchHeads>().head = 10;
            eraseBody.GetComponent<SwitchBodies>().body = 10;
            GetComponent<WaterTimer>().enabled = false;
        }
    }
}
