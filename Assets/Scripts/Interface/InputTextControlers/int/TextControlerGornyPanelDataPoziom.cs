using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class TextControlerGornyPanelDataPoziom : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _text;
    public int textJakoInt = 1;
    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom.ToString();
    }

    public void WyslijText()
    {
        _text.text = GetComponent<TextMeshProUGUI>().text;
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GornyPanelData>().Poziom = Convert.ToInt32(GetComponent<TextMeshProUGUI>().text);
    }


    public void DodajPoziom()
    {
        textJakoInt = Convert.ToInt32(GetComponent<TextMeshProUGUI>().text);
        
        if (textJakoInt < 20) textJakoInt++;
        GetComponent<TextMeshProUGUI>().text = textJakoInt.ToString();
    }

    public void OdejmijPoziom()
    {
        textJakoInt = Convert.ToInt32(GetComponent<TextMeshProUGUI>().text);

        if (textJakoInt > 1) textJakoInt--;
        GetComponent<TextMeshProUGUI>().text = textJakoInt.ToString();
    }

}
