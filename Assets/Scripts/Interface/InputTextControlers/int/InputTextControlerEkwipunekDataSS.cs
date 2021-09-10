using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerEkwipunekDataSS : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<EkwipunekData>().sztukiSrebra.ToString();
    }

    public void WyslijText()
    {
        if (GetComponent<TMP_InputField>().text != "") GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<EkwipunekData>().sztukiSrebra = Convert.ToInt32(GetComponent<TMP_InputField>().text);
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<EkwipunekData>().sztukiSrebra = 0;
    }
}


