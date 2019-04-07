using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScriptSP : MonoBehaviour
{



// Interpolate light color between two colors back and forth

int hb;
    Color color0 = Color.red;
    Color color1 = Color.green;

    Light lt;


    void Start()
    {
        hb = heartbeat(hb);
        lt = GetComponent<Light>();
    }
    void Update()
    {
        if (hb < 72 || hb > 80)
        {

            lt.color = color0;
        }
        else
        {
            lt.color = color1;
        }
    }
    int heartbeat (int number)
    {
        int x;
         x = 57;
        return x;
    }
}
