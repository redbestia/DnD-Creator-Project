using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boolControlerUmiejetnosciDataWiedzaTajemna : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    ZmianaKoloru button;

    private void Awake()
    {
        button = GetComponent<ZmianaKoloru>();
    }
    public void PobierzBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().wiedzaTajemna == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().wiedzaTajemna == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().wiedzaTajemna = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().wiedzaTajemna = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().wiedzaTajemna == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja) + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;
        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja);
        _text.text = mod.ToString();
    }
}
