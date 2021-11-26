using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RodzajBroni {Dystansowa, Finezyjna, Bia³a}
public enum RodzajObrazen {Kute, Obuchowe, Ciete} 
public class Bron : ScriptableObject
{
    public string Nazwa = "";
    public RodzajBroni RodzajBroni = RodzajBroni.Bia³a;
    public bool CzyBieglosc = false;
    public RodzajObrazen RodzajObrazen = RodzajObrazen.Ciete;
    public string Obrazenia = "";
    public string Opis = "";
}
