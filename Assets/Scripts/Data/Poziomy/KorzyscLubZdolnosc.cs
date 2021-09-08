using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorzyscLubZdolnosc : ScriptableObject , IComparable<KorzyscLubZdolnosc>
{
    public string Nazwa = "";
    public string Opis = "";
    public int level = 0;

    public int CompareTo(KorzyscLubZdolnosc comparePart)
    {
        if (comparePart == null)
            return 1;
        else
            return this.level.CompareTo(comparePart.level);
    }
}
