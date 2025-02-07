using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //script.enabled = true;
        }
    }
}
