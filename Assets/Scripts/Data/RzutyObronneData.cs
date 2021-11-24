using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RzutyObronneData : MonoBehaviour
{
    public bool sila = false;
    public bool zrecznosc = false;
    public bool kondycja = false;
    public bool inteligencja = false;
    public bool madrosc = false;
    public bool charyzma = false;

    public void UpdateData(RzutyObronneData ob)
    {
        sila = ob.sila;
        zrecznosc = ob.zrecznosc;
        kondycja = ob.kondycja;
        inteligencja = ob.inteligencja;
        madrosc = ob.madrosc;
        charyzma = ob.charyzma;
    }
}
