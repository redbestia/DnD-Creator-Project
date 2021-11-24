using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharakterWybor {PraworzadnyDobry, NeutralnyDobry, ChaotycznyDobry,PraworzadnyNeutralny, 
    Neutralny, ChaotycznyNeutralny, PraworzadnyZly, NeutralnyZly, ChaotycznyZly}
public class OpisData : MonoBehaviour
{
    public string Pochodzenie = "";
    public CharakterWybor Charakter;
    public string CechyOsobowosci = "";
    public string Idealy = "";
    public string Wiezi = "";
    public string Slabosci = "";
    public string Historia = "";
    public string Wyglad = "";

    public void UpdateData(OpisData ob)
    {
Pochodzenie = ob.Pochodzenie;
Charakter = ob.Charakter;
CechyOsobowosci = ob.CechyOsobowosci;
Idealy = ob.Idealy;
Wiezi = ob.Wiezi;
Slabosci = ob.Slabosci;
Historia = ob.Historia;
Wyglad = ob.Wyglad;
}

}
