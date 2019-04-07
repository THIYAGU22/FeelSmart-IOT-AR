using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User
{
    public String UserName;
    public int StoreValues;
    public int store_panValues;


    public User()
    {
        UserName = RetrieveDb.name;
        StoreValues = RetrieveDb.store_values;
        
    }
}

