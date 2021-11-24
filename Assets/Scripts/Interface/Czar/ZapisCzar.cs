using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZapisCzar : MonoBehaviour
{
    ///IF = InputField
    [SerializeField] TMP_InputField _nazwaIF;
    [SerializeField] TMP_InputField _poziomIF;
    [SerializeField] TMP_InputField _czasRzuczaniIF;
    [SerializeField] TMP_InputField _zasiegIF;
    [SerializeField] TMP_InputField _komponentyIF;
    [SerializeField] TMP_InputField _czasTrawaniaIF;
    [SerializeField] TMP_InputField _opisIF;

    ///Klasa z List¹ Czarów
    PoziomCzaru _data;
    private void Start()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<PoziomCzaru>();
    }
    public void Zapisz()
    {
        Czar czar = ScriptableObject.CreateInstance("Czar") as Czar;

        czar.Nazwa = _nazwaIF.text;
        czar.Poziom = Convert.ToInt32(_poziomIF.text);
        czar.CzasRzucania = float.Parse(_czasRzuczaniIF.text);
        czar.Zasieg = float.Parse(_zasiegIF.text);
        czar.Komponenty = _komponentyIF.text;
        czar.CzasTrwania = float.Parse(_czasTrawaniaIF.text);
        czar.Opis = _opisIF.text;

        _data.ListaCzarow.Add(czar);
    }
}
