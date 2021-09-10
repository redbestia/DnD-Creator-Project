using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerEkwipunekDataSM : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<EkwipunekData>().sztukiMiedzi.ToString();
    }

    public void WyslijText()
    {
        if (GetComponent<TMP_InputField>().text != "") GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<EkwipunekData>().sztukiMiedzi = Convert.ToInt32(GetComponent<TMP_InputField>().text);
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<EkwipunekData>().sztukiMiedzi = 0;
    }
}





