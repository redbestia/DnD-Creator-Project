using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System;

public class InputTextConrolerGornyGlowneStatystykiKosciWyrzymalosci : MonoBehaviour
{



    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().kosciWytrzymalosci;
    }
    public void WyslijText()
    {
        GameObject.FindGameObjectWithTag(Tagi.DataTag).
             GetComponent<GlowneStatystyki>().kosciWytrzymalosci = GetComponent<TextMeshProUGUI>().text;
    }
}
