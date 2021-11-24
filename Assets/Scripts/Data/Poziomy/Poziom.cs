using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poziom : MonoBehaviour
{
    public List<KorzyscLubZdolnosc> ListaKorzysciAndZdolnosci;
    public void UpdateData(Poziom ob)
    {
        ListaKorzysciAndZdolnosci = ob.ListaKorzysciAndZdolnosci;
    }
}