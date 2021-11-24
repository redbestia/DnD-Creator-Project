using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bieglosci : MonoBehaviour
{
    public string Uzbrojenie = "";
    public string Narzedzia = "";
    public string Jezyki = "";
    public string Inne = "";

    public void UpdateData(Bieglosci ob)
    {
        Uzbrojenie = ob.Uzbrojenie;
        Narzedzia = ob.Narzedzia;
        Jezyki = ob.Jezyki;
        Inne = ob.Inne;
    }

}
