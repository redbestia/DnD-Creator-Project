using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditPrzedmiot : MonoBehaviour
{
    [SerializeField] TMP_InputField _nazwaInputField;
    [SerializeField] TMP_InputField _iloscInputField;

    [SerializeField] ObjectInListReferencePrzedmiot _objectInListReference;

    public void Edit()
    {
        _objectInListReference.PrzedmiotObiekt.Nazwa = _nazwaInputField.text;
        _objectInListReference.PrzedmiotObiekt.Ilosc = float.Parse(_iloscInputField.text);

        GameObject.FindGameObjectWithTag(Tagi.SpawnerPrzedmiotTag).
            GetComponent<SpawnerPrzedmiot>().Spawn();
    }
}
