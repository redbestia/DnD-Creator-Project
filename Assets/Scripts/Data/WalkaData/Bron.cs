using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RodzajBroniEnum {Dystansowa, Finezyjna, Standardowa}
public class Bron
{
    public string Nazwa = "";
    public RodzajBroniEnum RodzajBroni = RodzajBroniEnum.Standardowa;
    public bool CzyBieglosc = false;
    public string Obrazenia = ""; 
}
