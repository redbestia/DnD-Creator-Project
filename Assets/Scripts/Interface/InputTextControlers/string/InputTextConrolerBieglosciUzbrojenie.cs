using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextConrolerBieglosciUzbrojenie : MonoBehaviour
{



    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<Bieglosci>().Uzbrojenie;
    }
    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<Bieglosci>().Uzbrojenie = GetComponent<TMP_InputField>().text;
    }








}
