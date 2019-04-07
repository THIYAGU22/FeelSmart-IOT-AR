using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class headRetrieve : MonoBehaviour
{
    int l;
    Color red = Color.red;
    Color green = Color.green;

    Light head_lt;

    public Text displayName;
    public InputField nameText;
    public static string name;

    public Text valueTexthead;
    public static int store_values;

    public GameObject head_light;

    User1 user = new User1();

    void Start()
    {
       // onSubmit(); 
    }


    public void onSubmit()
    {
        RetrieveFromDatabase();
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User1>("https://feelsmart-9ffe7.firebaseio.com/" + nameText.text + ".json").Then(response =>
        {
            //head_lt = head_light.GetComponentInChildren<Light>();
            user = response;

            UpdateValues();

        });
    }

    public void UpdateValues()
    {
        valueTexthead.text = "Body temperature is " + user.StoreValues1;

        head_lt = head_light.GetComponentInChildren<Light>();

        if ((int)user.StoreValues1 < 98 || (int) user.StoreValues1 > 99)
        {

            head_lt.color = red;
        }
        else
        {
            head_lt.color = green;
        }
    }
}
