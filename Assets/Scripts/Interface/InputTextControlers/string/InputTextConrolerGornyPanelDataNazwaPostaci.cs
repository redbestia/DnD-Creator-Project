using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class InputTextConrolerGornyPanelDataNazwaPostaci : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().nazwaPostaci;
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GornyPanelData>().nazwaPostaci = GetComponent<TMP_InputField>().text;
    }







   
}
 
