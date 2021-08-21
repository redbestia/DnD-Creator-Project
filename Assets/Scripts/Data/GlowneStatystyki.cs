using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowneStatystyki : MonoBehaviour
{
    public int sila = 0;
    public int zrecznosc = 0;
    public int kondycja = 0;
    public int inteligencja = 0;
    public int madrosc = 0;
    public int charyzma = 0;
    public int bieglosc = 0;
    public string kosciWytrzymalosci = "";

    public int Modfikator(int wynik)
    {
        return wynik / 2 - 5;
    }

}
