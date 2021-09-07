using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerOpisDataPochodzenie : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Pochodzenie;
    }
    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<OpisData>().Pochodzenie = GetComponent<TMP_InputField>().text;
    }

}