using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerOpisDataCechyOsobowsci : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().CechyOsobowosci;
    }
    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<OpisData>().CechyOsobowosci = GetComponent<TMP_InputField>().text;
    }

}