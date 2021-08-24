using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerGlowneStatystykiAktualnaIloscKosciWytrzymalosci : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci.ToString();
    }

    public void OdejmijKosc()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci > 0) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci--;
    }

    public void DodajKosc()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci < GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci++;
    }

    public void OdnowKosci()
    {
        if(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom % 2 == 0) GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci + GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom / 2;
        else if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom % 2 != 0) GameObject.
    FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci = GameObject.
    FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci + 1 + GameObject.
    FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom / 2;
        
        if (GameObject.
    FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci > GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom) GameObject.
    FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().aktualnaIloscKosciWytrzymalosci = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GornyPanelData>().Poziom;

    }

}
