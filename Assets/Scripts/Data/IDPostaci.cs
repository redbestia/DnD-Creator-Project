using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDPostaci : MonoBehaviour
{
    public int ID;
    public void UpdateData(IDPostaci ob)
    {
        ID = ob.ID;
    }
}
