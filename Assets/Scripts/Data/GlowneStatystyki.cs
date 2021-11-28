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
    public int kosciWytrzymalosci = 0;
    public int aktualnaIloscKosciWytrzymalosci = 0;
    public int Modfikator(int wynik)
    {
        return wynik / 2 - 5;
    }
    public static int ModfikatorStatic(int wynik)
    {
        return wynik / 2 - 5;
    }


    public void UpdateData(GlowneStatystyki ob)
    {
        sila = ob.sila;
        zrecznosc = ob.zrecznosc;
        kondycja = ob.kondycja;
        madrosc = ob.inteligencja;
        charyzma = ob.charyzma;
        bieglosc = ob.bieglosc;
        kosciWytrzymalosci = ob.kosciWytrzymalosci;
        aktualnaIloscKosciWytrzymalosci= ob.aktualnaIloscKosciWytrzymalosci;
    }

}
