using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;

public class inspectHeartScript :valueRetrieve_heart
{

    public Text displayHeart;

    
    // Start is called before the first frame update


    public void onSubmit()
    {
        UpdateValues();
    }

   

    public void UpdateValues()
    {
        displayHeart.text = "heart value is ...." + get_value;
    }


    }

