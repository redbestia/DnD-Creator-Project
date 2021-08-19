using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using DnD;


public class InputTextConroler : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] GameObject data;
    
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().nazwaPostaci;
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().nazwaPostaci = GetComponent<TMP_InputField>().text;
    }




   
}
 
