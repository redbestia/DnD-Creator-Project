using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RodzajBroniEnum {Dystansowa, Finezyjna, Bia³a}
public class Bron
{
    public string Nazwa = "";
    public RodzajBroniEnum RodzajBroni = RodzajBroniEnum.Bia³a;
    public bool CzyBieglosc = false;
    public string Obrazenia = ""; 
}
