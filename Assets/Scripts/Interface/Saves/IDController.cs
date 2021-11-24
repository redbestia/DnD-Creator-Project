using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDController : MonoBehaviour
{
    public static int IDDoWysylki;
    public static IDController ID;
    void Start()
    {
        if (ID != null)
        {
            Destroy(gameObject);
            return;
        }

        ID = this;
        DontDestroyOnLoad(gameObject);
    }
}