using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boolControlerUmiejetnosciDataAtletyka : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    ZmianaKoloru button;

    private void Awake()
    {
        button = GetComponent<ZmianaKoloru>();
    }
    public void PobierzBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().atletyka == true) button.ZmienNaCzarny();
        else button.ZmienNaBialy();
    }

    public void ZmienBool()
    {
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().atletyka == true)
            GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().atletyka = false;
        else GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().atletyka = true;
    }

    public void WyswietlModyfikator()
    {
        int mod = 0;
        if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<UmiejetnosciData>().atletyka == true)
            mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().sila) + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc;
        else mod = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().sila);
        _text.text = mod.ToString();
    }
}
