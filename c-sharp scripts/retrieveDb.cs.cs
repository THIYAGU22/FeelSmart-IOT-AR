using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;

public class RetrieveDb : MonoBehaviour
{

    public Text displayName;
    public InputField nameText;

    public InputField values;
    public Text valueText;

    public static string name;
    public static int store_values;

    User user = new User();

    // Start is called before the first frame update


    public void onSubmit()
    {
        name = nameText.text;
        store_values = int.Parse(values.text);
        PostToDatabase();
    }

    public void onGetScores()
    {
        RetrieveFromDatabase();
    }


    private void PostToDatabase()
    {
        User user = new User();

        RestClient.Put("https://feelsmart-9ffe7.firebaseio.com/" + name + ".json", user);
        RestClient.Put("https://feelsmart-9ffe7.firebaseio.com/" + store_values + ".json", user);
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
        displayName.text = " stored name is " + user.UserName;
        valueText.text = "store value is " + user.StoreValues.ToString();
    }
}

