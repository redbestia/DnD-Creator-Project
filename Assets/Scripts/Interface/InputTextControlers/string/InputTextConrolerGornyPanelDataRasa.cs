using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class InputTextConrolerGornyPanelDataRasa : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Rasa;
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GornyPanelData>().Rasa = GetComponent<TMP_InputField>().text;
    }

}

