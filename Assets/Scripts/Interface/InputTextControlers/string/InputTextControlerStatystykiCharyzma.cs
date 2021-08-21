using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class InputTextControlerStatystykiCharyzma : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = Convert.ToString(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>()
            .charyzma);
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;

        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GlowneStatystyki>().charyzma
            = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }
}
