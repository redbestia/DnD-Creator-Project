using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerMagiaModAtaku : MonoBehaviour
{

    public void PobierzText()
    {
        if (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Charyzma)
        {
            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().charyzma) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc > 0) GetComponent<TextMeshProUGUI>().text = "+" + (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().charyzma) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            else
            {
                GetComponent<TextMeshProUGUI>().text = (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().charyzma) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            }
        }
        if (GameObject.
    FindGameObjectWithTag(Tagi.DataTag).
    GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Madrosc)
        {
            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc > 0) GetComponent<TextMeshProUGUI>().text = "+" + (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            else
            {
                GetComponent<TextMeshProUGUI>().text = (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().madrosc) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            }
        }
        if (GameObject.
    FindGameObjectWithTag(Tagi.DataTag).
    GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow == UmiejetnoscDoRzucaniaCzarowWybor.Inteligencja)
        {
            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc > 0) GetComponent<TextMeshProUGUI>().text = "+" + (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            else
            {
                GetComponent<TextMeshProUGUI>().text = (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
       (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().inteligencja) + GameObject.
       FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().bieglosc)
    .ToString();
            }
        }
        }
}

