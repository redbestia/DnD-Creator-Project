using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InputTextControlerStatystykiKondycja : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text = Convert.ToString(GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>()
            .kondycja);
    }
    public void WyslijText()
    {
        _text.text = GetComponent<TMP_InputField>().text;

        GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<GlowneStatystyki>().kondycja
            = Convert.ToInt32(GetComponent<TMP_InputField>().text);
    }
}
