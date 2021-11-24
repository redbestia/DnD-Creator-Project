using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlasaPancerzaISzybkosc : MonoBehaviour
{
    public string KlasaPancerza = "";
    public double Szybkosc = 0;

    public void UpdateData(KlasaPancerzaISzybkosc ob)
    {
        KlasaPancerza = ob.KlasaPancerza;
        Szybkosc = ob.Szybkosc;
    }
}
