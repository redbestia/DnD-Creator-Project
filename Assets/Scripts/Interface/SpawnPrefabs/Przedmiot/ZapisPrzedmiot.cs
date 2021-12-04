using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZapisPrzedmiot : MonoBehaviour
{
    [SerializeField] TMP_InputField _przedmiotNazwaInputFiled;
    [SerializeField] TMP_InputField _iloœæNazwaInputFiled;

    EkwipunekData _data;
    private void Start()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<EkwipunekData>();
    }
    public void Zapisz()
    {
        Przedmiot przedmiot = ScriptableObject.CreateInstance("Przedmiot") as Przedmiot;

        przedmiot.Nazwa = _przedmiotNazwaInputFiled.text;
        przedmiot.Ilosc =  getStringFormFloat(_iloœæNazwaInputFiled.text);
        _data.ListaPrzedmiotow.Add(przedmiot);
    }

    float getStringFormFloat(string input)
    {
        if (input == "")
            return 0.0f;
        else
            return float.Parse(input);
    }
}
