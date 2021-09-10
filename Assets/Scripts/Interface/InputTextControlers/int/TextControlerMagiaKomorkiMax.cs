using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class TextControlerMagiaKomorkiMax : MonoBehaviour
{
    [SerializeField] int wybieracz = 0;
    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiMax[wybieracz].ToString();
    }
    public void PobierzTextInputFIeld()
    {
        GetComponent<TMP_InputField>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiMax[wybieracz].ToString();
    }

    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<PoziomCzaru>().KomorkiMax[wybieracz] = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }


}
