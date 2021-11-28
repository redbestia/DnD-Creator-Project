using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditBron : MonoBehaviour
{
    [SerializeField] TMP_InputField _bronNazwaInputFiled;
    [SerializeField] EnumControlerBron _bronRodzajBroni;
    [SerializeField] ButtonControlerBron _bronCzyBieglosc;
    [SerializeField] EnumControlerRodzajObrazen _bronRodzajObrazen;
    [SerializeField] TMP_InputField _bronObrazeniaInputFiled;
    [SerializeField] TMP_InputField _bronOpisInputFiled;

    [SerializeField] ObjectInListReferenceBron _objectInListReference;

   
    public void Edit()
    {
        _objectInListReference.BronReference.Nazwa = _bronNazwaInputFiled.text;
        _objectInListReference.BronReference.RodzajBroni = _bronRodzajBroni.RodzajBroniControl;
        _objectInListReference.BronReference.CzyBieglosc = _bronCzyBieglosc.IsPressed;
        _objectInListReference.BronReference.RodzajObrazen = _bronRodzajObrazen.RodzajObrazenControl;
        _objectInListReference.BronReference.Obrazenia = _bronObrazeniaInputFiled.text;
        _objectInListReference.BronReference.Opis = _bronOpisInputFiled.text;

        GameObject.FindGameObjectWithTag(Tagi.SpawnerBronTag).GetComponent<SpawnerBron>().Spawn();
    }
}
