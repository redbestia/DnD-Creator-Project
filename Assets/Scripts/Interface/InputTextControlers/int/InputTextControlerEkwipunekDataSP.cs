using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerEkwipunekDataSP : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<EkwipunekData>().sztukiPlatyny.ToString();
    }

    public void WyslijText()
    {
        if (GetComponent<TMP_InputField>().text != "") GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<EkwipunekData>().sztukiPlatyny = Convert.ToInt32(GetComponent<TMP_InputField>().text);
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<EkwipunekData>().sztukiPlatyny = 0;
    }
}




