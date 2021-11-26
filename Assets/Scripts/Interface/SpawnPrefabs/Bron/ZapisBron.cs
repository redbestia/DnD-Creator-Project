using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZapisBron : MonoBehaviour
{
    [SerializeField] TMP_InputField _bronNazwaInputFiled;
    [SerializeField] EnumControlerBron _bronRodzajBroni;
    [SerializeField] ButtonControlerBron _bronCzyBieglosc;
    [SerializeField] EnumControlerRodzajObrazen _bronRodzajObrazen;
    [SerializeField] TMP_InputField _bronObrazeniaInputFiled;
    [SerializeField] TMP_InputField _bronOpisInputFiled;

    ListaBroni _data;
    private void Start()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<ListaBroni>();
    }
    public void Zapisz()
    {
        Bron bron = ScriptableObject.CreateInstance("Bron") as Bron;

        bron.Nazwa = _bronNazwaInputFiled.text;
        bron.RodzajBroni = _bronRodzajBroni.RodzajBroniControl;
        bron.CzyBieglosc = _bronCzyBieglosc.IsPressed;
        bron.RodzajObrazen = _bronRodzajObrazen.RodzajObrazenControl;
        bron.Obrazenia = _bronObrazeniaInputFiled.text;
        bron.Opis = _bronOpisInputFiled.text;

        _data.PosiadaneBronie.Add(bron);
    }
}
