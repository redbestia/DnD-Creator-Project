using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boolControlerUmiejetnosciDataPercepcja : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    ZmianaKoloru button;

    private void Awake()
    {
        button = GetComponent<ZmianaKoloru>();
    }
    public void PobierzBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().percepcja == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().percepcja == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().percepcja = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().percepcja = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().percepcja == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;
        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc);
        _text.text = mod.ToString();
    }
}
