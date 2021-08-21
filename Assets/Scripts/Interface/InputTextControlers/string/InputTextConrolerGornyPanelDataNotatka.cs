using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextConrolerGornyPanelDataNotatka : MonoBehaviour
{



    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().notka;
    }
    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<GornyPanelData>().notka = GetComponent<TMP_InputField>().text;
    }








}
