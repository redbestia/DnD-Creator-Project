using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHaightTest : MonoBehaviour
{
    TextMeshProUGUI _textMeshProUGUI;
    private void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        Debug.Log(_textMeshProUGUI.preferredHeight);
    }
}
