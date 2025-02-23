using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTimer : MonoBehaviour
{
    public float moist;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moist += Time.deltaTime;
        
     
    }

    
}
