using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GornyPanelData : MonoBehaviour
{
    [SerializeField] public string nazwaPostaci { get; set; } = "";
    public string Klasa = "";
    public int Poziom = 0;
    public string Rasa = "";
    public int HPMax = 0;
    public int HPAktualne = 0;
    public string notka = "";

    public void NazwaPostaciReturn()
    {
    }
}
