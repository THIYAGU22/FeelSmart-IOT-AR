using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imgclose : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPane()
    {
        if (Panel != null)

        {
            Panel.SetActive(false);
        }
    }
}