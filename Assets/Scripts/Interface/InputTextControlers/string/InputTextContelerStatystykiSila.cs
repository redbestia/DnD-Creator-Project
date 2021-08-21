using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class InputTextContelerStatystykiSila : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = Convert.ToString(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>()
            .sila);
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;

        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GlowneStatystyki>().sila 
            = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }
}
