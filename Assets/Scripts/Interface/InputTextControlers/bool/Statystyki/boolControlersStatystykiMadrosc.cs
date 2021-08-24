using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boolControlersStatystykiMadrosc : MonoBehaviour
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
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().madrosc == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().madrosc == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().madrosc = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().madrosc = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().madrosc == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) +
               GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;

        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc);
        _teksRzutyObronne.text = mod.ToString();

        _teksStatystyki.text = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc).ToString();
    }

}
