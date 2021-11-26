using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerCzarKomponenty : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceCzar _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.CzarObiekt.Komponenty;
    }
}
