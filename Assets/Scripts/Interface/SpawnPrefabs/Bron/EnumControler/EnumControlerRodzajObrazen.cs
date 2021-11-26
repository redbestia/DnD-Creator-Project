using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnumControlerRodzajObrazen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _wyswietlanyNaButtonieText;
    [HideInInspector] public RodzajObrazen RodzajObrazenControl = RodzajObrazen.Ciete;

    public void SetRodajBroni_Kute()
    {
        RodzajObrazenControl = RodzajObrazen.Kute;
        _wyswietlanyNaButtonieText.text = "Kute";
    }

    public void SetRodajBroni_Obuchowe()
    {
        RodzajObrazenControl = RodzajObrazen.Obuchowe;
        _wyswietlanyNaButtonieText.text = "Obuchowe";
    }

    public void SetRodajBroni_Ciete()
    {
        RodzajObrazenControl = RodzajObrazen.Ciete;
        _wyswietlanyNaButtonieText.text = "Ciête";
    }
}
