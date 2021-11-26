using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zapis_Notatka : MonoBehaviour
{
    [SerializeField] TMP_InputField _notatkaInputFiled;
    Notatki _data;
    private void Start()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<Notatki>();
    }
    public void ZapiszNotatki()
    {
        Notatka notatka = ScriptableObject.CreateInstance("Notatka") as Notatka;

        notatka.NotatkaText = _notatkaInputFiled.text;
        _data.ListaNotatek.Add(notatka);
    }

}
