using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerBronNazwa : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.BronReference.Nazwa;
    }
}
