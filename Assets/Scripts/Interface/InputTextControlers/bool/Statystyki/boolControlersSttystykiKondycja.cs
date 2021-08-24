using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class boolControlersSttystykiKondycja : MonoBehaviour
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
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().kondycja == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().kondycja == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().kondycja = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().kondycja = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyObronneData>().kondycja == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().kondycja) +
               GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;

        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().kondycja);
        _teksRzutyObronne.text = mod.ToString();

        _teksStatystyki.text = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().kondycja).ToString();
    }

}
