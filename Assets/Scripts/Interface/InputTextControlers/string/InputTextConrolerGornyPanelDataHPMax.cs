using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextConrolerGornyPanelDataHPMax : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPMax.ToString();
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;
       GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GornyPanelData>().HPMax = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }








}

