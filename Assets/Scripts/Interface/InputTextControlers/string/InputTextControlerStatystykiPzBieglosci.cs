using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class InputTextControlerStatystykiPzBieglosci : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = Convert.ToString(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>()
            .bieglosc);
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;

        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GlowneStatystyki>().bieglosc
            = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }

}
