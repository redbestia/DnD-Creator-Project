using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerGornyPanelDataHPAktualne : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPAktualne.ToString();
    }

    public void Dodaj1HP()
    {
        GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPAktualne++;
    }

    public void Odejmij1HP()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPAktualne > 0) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPAktualne--;
    }

    public void WyleczDoFulla()
    {
        GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPAktualne = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().HPMax;
    }

}
