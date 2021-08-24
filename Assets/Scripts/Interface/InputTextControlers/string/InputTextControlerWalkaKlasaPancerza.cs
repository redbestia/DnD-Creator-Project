using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextControlerWalkaKlasaPancerza : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<KlasaPancerzaISzybkosc>().KlasaPancerza.ToString();
    }

    public void WyslijText()
    {
        _text.text = GetComponent<TextMeshProUGUI>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<KlasaPancerzaISzybkosc>().KlasaPancerza = GetComponent<TextMeshProUGUI>().text;
    }


    public void PobierzTextInputField()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<KlasaPancerzaISzybkosc>().KlasaPancerza.ToString();
    }

    public void WyslijTextInputFIeld()
    {
        _text.text = GetComponent<TMP_InputField>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<KlasaPancerzaISzybkosc>().KlasaPancerza = GetComponent<TMP_InputField>().text;
    }
}