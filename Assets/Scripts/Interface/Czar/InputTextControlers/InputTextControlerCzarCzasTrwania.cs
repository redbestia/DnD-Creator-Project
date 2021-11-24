using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerCzarCzasTrwania : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceCzar _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.CzarObiekt.CzasTrwania.ToString();
    }
}
