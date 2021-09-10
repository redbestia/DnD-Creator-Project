using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerMagiaKomorkiCzarowAktualne : MonoBehaviour
{
    [SerializeField] int wybieracz=0;

    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[wybieracz].ToString();
    }

    public void Dodaj1Kom()
    {
        if(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[wybieracz] < GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiMax[wybieracz])
        GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[wybieracz]++;
    }

    public void Odejmij1Kom()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[wybieracz] > 0) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[wybieracz]--;
    }

    public void OdnowWszystkieKom()
    {
        for (int i = 0; i < GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne.Count; i++)
        {
            GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiAktualne[i] = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>().KomorkiMax[i];
        }
    }

}


