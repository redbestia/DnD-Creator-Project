using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boolControlersStatystykiZrecznosc : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _teksRzutyObronne;
    [SerializeField] TextMeshProUGUI _teksStatystyki;

    ZmianaKoloru button;


    private void Awake()
    {
        button = GetComponent<ZmianaKoloru>();
    }
    public void PobierzBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().zrecznosc == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().zrecznosc == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().zrecznosc = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().zrecznosc = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().zrecznosc == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().zrecznosc) +
               GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;

        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().zrecznosc);
        _teksRzutyObronne.text = mod.ToString();

        _teksStatystyki.text = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().zrecznosc).ToString();
    }

}
