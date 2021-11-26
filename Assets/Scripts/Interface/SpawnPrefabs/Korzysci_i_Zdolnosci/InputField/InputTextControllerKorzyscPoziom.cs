using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputTextControllerKorzyscPoziom : MonoBehaviour
{
    [SerializeField] ObjectInListReference _objectInListReference;
    public void PobierzText()
    {
        GetComponent<TMP_InputField>().text =
            _objectInListReference.KorzyscLubZdolnosc.level.ToString();
    }
}
