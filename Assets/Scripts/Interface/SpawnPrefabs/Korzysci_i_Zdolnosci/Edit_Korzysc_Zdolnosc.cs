using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Edit_Korzysc_Zdolnosc : MonoBehaviour
{
    [SerializeField] TMP_InputField _nazwaInputFiled;
    [SerializeField] TMP_InputField _poziomInputFiled;
    [SerializeField] TMP_InputField _opisInputFiled;
    [SerializeField] ObjectInListReference _objectInListReference;
    public void EditKorzyci_i_Zdolnosci()
    {
        _objectInListReference.KorzyscLubZdolnosc.Nazwa = _nazwaInputFiled.text;
        _objectInListReference.KorzyscLubZdolnosc.Opis = _opisInputFiled.text;

        if(_poziomInputFiled.text =="")
            _objectInListReference.KorzyscLubZdolnosc.level = 0;
        else
            _objectInListReference.KorzyscLubZdolnosc.level = 
                Convert.ToInt32(_poziomInputFiled.text);

        GameObject.FindGameObjectWithTag(Tagi.SpawnerKorzyscLubZdolnoscTag).
            GetComponent<Spawner_Korzysci_Zdolnosci>().SpwanListOfKorzysci_i_Zdolnosci();
    }
}
