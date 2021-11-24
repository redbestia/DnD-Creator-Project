using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notatki : MonoBehaviour
{
    public List<Notatka> ListaNotatek;

    public void UpdateData(Notatki ob)
    {
        ListaNotatek = ob.ListaNotatek;
    }
}
