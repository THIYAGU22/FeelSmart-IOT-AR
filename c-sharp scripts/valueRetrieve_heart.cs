using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using UnityEngine.SceneManagement;
public class valueRetrieve_heart : MonoBehaviour
{

    int l;
    Color red = Color.red;
    Color green = Color.green;

    Light heart_lt;

    public Text displayName;
    public InputField nameText;
    public static string name;
    public Button myButton;
    
    public Text valueTextHeart;
    public static int store_values;

    public GameObject heart_light;
    public int get_value = 0;
    User user = new User();

    void Start()
    {
       // onSubmit();
        heart_lt = heart_light.GetComponentInChildren<Light>();
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
        valueTextHeart.text = "heart value is " + user.StoreValues;
        get_value = user.StoreValues;

        heart_lt = heart_light.GetComponentInChildren<Light>();

        if (user.StoreValues < 72 || user.StoreValues > 80)

        { 

            heart_lt.color = Color.red;
        }
        else
        {
            myButton.interactable = false;
            heart_lt.color = Color.green;
        }
       
    }

    
}
