using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldClear : MonoBehaviour
{
    public void Clear()
    {
        GetComponent<TMP_InputField>().text = "";
    }
}
