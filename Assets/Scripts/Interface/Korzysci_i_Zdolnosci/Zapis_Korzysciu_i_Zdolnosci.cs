using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Zapis_Korzysciu_i_Zdolnosci : MonoBehaviour
{
    [SerializeField] TMP_InputField _nazwaInputFiled;
    [SerializeField] TMP_InputField _poziomInputFiled;
    [SerializeField] TMP_InputField _opisInputFiled;
    Poziom _data;
    private void Start()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<Poziom>();
    }
    public void ZapiszKorzyci_i_Zdolnosci()
    {
        KorzyscLubZdolnosc korzyscLubZdolnosc = ScriptableObject.CreateInstance("KorzyscLubZdolnosc")
            as KorzyscLubZdolnosc;

        korzyscLubZdolnosc.Nazwa = _nazwaInputFiled.text;
        korzyscLubZdolnosc.level = Convert.ToInt32(_poziomInputFiled.text);
        korzyscLubZdolnosc.Opis = _opisInputFiled.text;

        _data.ListaKorzysciAndZdolnosci.Add(korzyscLubZdolnosc);
    }

}
