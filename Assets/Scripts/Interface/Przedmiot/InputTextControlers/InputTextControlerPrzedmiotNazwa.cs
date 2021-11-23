using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerPrzedmiotNazwa : MonoBehaviour
{
    [SerializeField] ObjectInListReferencePrzedmiot _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.PrzedmiotObiekt.Nazwa;
    }
}
