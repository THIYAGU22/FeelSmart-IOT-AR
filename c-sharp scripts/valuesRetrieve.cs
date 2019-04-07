using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class valuesRetrieve : MonoBehaviour
{

    int l;
    Color red = Color.red;
    Color green = Color.green;

    Light liver_lt;

    public Text displayName;
    public InputField nameText;
    public static string name;

    public Text valueText;
    public static int store_values;

    public GameObject liver_light;

    User user = new User();

    void Start()
    {
        onSubmit();
        liver_lt = liver_light.GetComponent<Light>();
    }


    public void onSubmit()
    {
        RetrieveFromDatabase();
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://feelsmart-9ffe7.firebaseio.com/" + nameText.text + ".json").Then(response =>
        {
            user = response;

            UpdateValues();

        });
    }

    public void UpdateValues()
    {
        valueText.text = "store value is " + user.StoreValues;

        liver_lt = liver_light.GetComponentInChildren<Light>();
        //user.StoreValues = 75;


        if (user.StoreValues < 72 || user.StoreValues > 80)
        {

            liver_lt.color = red;
        }
        else
        {
            liver_lt.color = green;
        }



    }
}

 

    
        
    

