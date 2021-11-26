using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnumControlerBron : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _wyswietlanyNaButtonieText;
    [HideInInspector] public RodzajBroni RodzajBroniControl = RodzajBroni.Bia³a;

    public void SetRodajBroni_Dystansowa()
    {
        RodzajBroniControl = RodzajBroni.Dystansowa;
        _wyswietlanyNaButtonieText.text = "Dystansowa";
    }

    public void SetRodajBroni_Finezyjna()
    {
        RodzajBroniControl = RodzajBroni.Finezyjna;
        _wyswietlanyNaButtonieText.text = "Finezyjna";
    }

    public void SetRodajBroni_Bia³a()
    {
        RodzajBroniControl = RodzajBroni.Bia³a;
        _wyswietlanyNaButtonieText.text = "Bia³a";
    }
}
