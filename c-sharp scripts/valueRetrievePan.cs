using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class valueRetrievePan : MonoBehaviour
{
    int l;
    Color red = Color.red;
    Color green = Color.green;

    Light pan_lt;

    public Text displayName;
    public InputField nameText;
    public static string name;

    public Text valueTextPan;
    public static int store_values;

    public GameObject pan_light;

    User1 user = new User1();

    void Start()
    {
        //onSubmit();
        pan_lt = pan_light.GetComponentInChildren<Light>();
    }


    public void onSubmit()
    {
        RetrieveFromDatabase();
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User1>("https://feelsmart-9ffe7.firebaseio.com/" + nameText.text + ".json").Then(response =>
        {
            user = response;

            UpdateValues();

        });
    }

    public void UpdateValues()
    {
        valueTextPan.text = "pancreas value is " + user.StoreValues2;

        pan_lt = pan_light.GetComponentInChildren<Light>();
       

    
        if (user.StoreValues2 < 110 || user.StoreValues2 > 90)
        {

            pan_lt.color = red;
        }
        else
        {
            pan_lt.color = green;
        }
    }
}
