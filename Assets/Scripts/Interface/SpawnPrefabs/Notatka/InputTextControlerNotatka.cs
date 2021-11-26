using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControlerNotatka : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceNotatka _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.Notatka.NotatkaText;
    }
}
