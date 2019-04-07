using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScripthead : MonoBehaviour
{
    // Interpolate light color between two colors back and forth

    int hd;
    Color color0 = Color.red;
    Color color1 = Color.green;

    Light lt;

    void Start()
    {
        hd = head(hd);
        lt = GetComponent<Light>();
    }
    void Update()
    {
        if (hd < 72 || hd > 80)
        {

            lt.color = color0;
       
        }
        else
        {
            lt.color = color1;
        }
    }
    int head(int number)
    {
        int x;
        x = 57;
        return x;
    }
}
