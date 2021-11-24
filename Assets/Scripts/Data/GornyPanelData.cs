using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GornyPanelData : MonoBehaviour
{
    public string nazwaPostaci ="";
    public string Klasa = "";
    public int Poziom = 0;
    public string Rasa = "";
    public int HPMax = 0;
    public int HPAktualne = 0;
    public string notka = "";

    public void NazwaPostaciReturn()
    {
    }
    public void UpdateData(GornyPanelData ob)
    {
        nazwaPostaci = ob.nazwaPostaci;
        Klasa = ob.Klasa;
        Poziom = ob.Poziom;
        Rasa = ob.Rasa;
        HPMax = ob.HPMax;
        HPAktualne = ob.HPAktualne;
        notka = ob.notka;
    }
}
