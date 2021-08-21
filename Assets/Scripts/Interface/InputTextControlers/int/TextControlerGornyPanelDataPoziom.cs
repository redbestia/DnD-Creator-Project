using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerGornyPanelDataPoziom : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom.ToString();
    }



    public void DodajPoziom()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom < 20) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom++;
    }

    public void OdejmijPoziom()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom > 0) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom--;
    }

}
