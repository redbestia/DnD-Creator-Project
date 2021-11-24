using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaBroni : MonoBehaviour
{
    public List<Bron> PosiadaneBronie;
    public void UpdateData(ListaBroni ob)
    {
        PosiadaneBronie = ob.PosiadaneBronie;
    }
}
