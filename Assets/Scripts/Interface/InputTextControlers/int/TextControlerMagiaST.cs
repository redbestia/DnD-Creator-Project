using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerMagiaST : MonoBehaviour
{

    public void PobierzText()
    {
        if(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Charyzma)
        {
            GetComponent<TextMeshProUGUI>().text =
                (8 + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
   (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().zrecznosc) + GameObject.
   FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
.ToString();
        }
        if (GameObject.
    FindGameObjectWithTag(Tagi.DataTag).
    GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Madrosc)
        {
            GetComponent<TextMeshProUGUI>().text =
                (8 + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
   (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.
   FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
.ToString();
        }
        if (GameObject.
    FindGameObjectWithTag(Tagi.DataTag).
    GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Inteligencja)
        {
            GetComponent<TextMeshProUGUI>().text =
                (8 + GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
   (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja) + GameObject.
   FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
.ToString();
        }
    }
}