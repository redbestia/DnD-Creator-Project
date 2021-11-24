using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerCzarCzasRzucania : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceCzar _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.CzarObiekt.CzasRzucania.ToString();
    }
}
