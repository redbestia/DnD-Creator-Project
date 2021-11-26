using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonControlerBron : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textButton;
    [HideInInspector]public bool IsPressed = false;

    public void ZminaStanuNacisniecia()
    {
        if(IsPressed == false)
        {
            IsPressed = true;
            _textButton.text = "Tak";
        }
        else
        {
            IsPressed = false;
            _textButton.text = "Nie";

        }
    }
}
