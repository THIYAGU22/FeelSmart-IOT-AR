/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/


using System;

public class User1
{
    public String UserName;
    public int StoreValues;
    public int StoreValues1;
    public int StoreValues2;
   // public String StoreValues;

    public User1()
    {
        UserName = RetrieveDb.name;
        StoreValues2 = valueRetrievePan.store_values;
        StoreValues = valueRetrieve_heart.store_values;
        StoreValues1 = headRetrieve.store_values;
    }
}
