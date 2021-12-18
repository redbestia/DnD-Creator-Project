using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditCzar : MonoBehaviour
{
    [SerializeField] TMP_InputField _nazwaIF;
    [SerializeField] TMP_InputField _poziomIF;
    [SerializeField] TMP_InputField _czasRzuczaniIF;
    [SerializeField] TMP_InputField _zasiegIF;
    [SerializeField] TMP_InputField _komponentyIF;
    [SerializeField] TMP_InputField _czasTrawaniaIF;
    [SerializeField] TMP_InputField _opisIF;

    [SerializeField] ObjectInListReferenceCzar _objectInListReference;

    public void Edit()
    {
        _objectInListReference.CzarObiekt.Nazwa = _nazwaIF.text;
        _objectInListReference.CzarObiekt.Poziom = int.Parse(_poziomIF.text);
        _objectInListReference.CzarObiekt.CzasRzucania = (_czasRzuczaniIF.text);
        _objectInListReference.CzarObiekt.Zasieg = (_zasiegIF.text);
        _objectInListReference.CzarObiekt.Komponenty = _komponentyIF.text;
        _objectInListReference.CzarObiekt.CzasTrwania = (_czasTrawaniaIF.text);
        _objectInListReference.CzarObiekt.Opis = _opisIF.text;

        GameObject.FindGameObjectWithTag(Tagi.SpawnerCzarTag).
            GetComponent<SpawnerPrzedmiot>().Spawn();
    }
}
