using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerStatystykiKoscWytrzymalosci : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = Convert.ToString(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>()
            .madrosc);
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;

        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GlowneStatystyki>().madrosc
            = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }
}
