using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boolControlerUmiejetnosciDataOpiekaNadZwierzetami : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    ZmianaKoloru button;

    private void Awake()
    {
        button = GetComponent<ZmianaKoloru>();
    }
    public void PobierzBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().opiekaNadZwierzetami == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().opiekaNadZwierzetami == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().opiekaNadZwierzetami = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().opiekaNadZwierzetami = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().opiekaNadZwierzetami == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;
        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc);
        _text.text = mod.ToString();
    }
}
