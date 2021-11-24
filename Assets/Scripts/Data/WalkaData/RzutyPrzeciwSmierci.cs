using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RzutyPrzeciwSmierci : MonoBehaviour
{
    public bool[] Sukcesy = new bool[3];

    public bool[] Porazki = new bool[3];

    public void UpdateData(RzutyPrzeciwSmierci ob)
    {
        Sukcesy = ob.Sukcesy;
        Porazki = ob.Porazki;
    }
}
