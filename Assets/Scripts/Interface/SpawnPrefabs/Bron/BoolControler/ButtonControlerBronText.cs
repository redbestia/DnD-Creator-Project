using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonControlerBronText : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;
    [SerializeField] ButtonControlerBron _buttonControler;
    public void PobierzText()
    {
        if(_objectInListReference.BronReference.CzyBieglosc)
        {
            GetComponent<TextMeshProUGUI>().text = "Tak";
            _buttonControler.IsPressed = true;
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "Nie";
            _buttonControler.IsPressed = false;

        }
    }
}
