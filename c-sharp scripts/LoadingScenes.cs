using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using UnityEngine.SceneManagement;
using System;
using System.Threading.Tasks;
public class LoadingScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void openPancreas()
    {
        SceneManager.LoadScene("pancreasInspect");
    }

    public void openLiver()
    {
        SceneManager.LoadScene("inspectLiver");
    }

    public void openHeart()
    {
        SceneManager.LoadScene("inspectHeart");
    }

    public void onBackButtonPressed()
    {
        SceneManager.LoadScene("vetrivelsad");
    }
    public void ShowHospitals()
    {
        SceneManager.LoadScene("nearbyHospitals");
    }
}
