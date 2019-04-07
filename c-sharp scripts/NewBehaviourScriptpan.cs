using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptpan : MonoBehaviour
{
    // Interpolate light color between two colors back and forth

    int p;
    Color color0 = Color.red;
    Color color1 = Color.green;

    Light lt;

    void Start()
    {
        p = pan(p);
        lt = GetComponent<Light>();
    }
    void Update()
    {
        if (p < 72 || p > 80)
        {

            lt.color = color0;
        }
        else
        {
            lt.color = color1;
        }
    }
    int pan(int number)
    {
        int x;
        x = 75;
        return x;
    }
}

