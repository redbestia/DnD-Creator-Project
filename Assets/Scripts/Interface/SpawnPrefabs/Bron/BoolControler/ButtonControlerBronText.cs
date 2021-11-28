using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonControlerBronText : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;
    public void PobierzText()
    {
        if(_objectInListReference.BronReference.CzyBieglosc)
        {
            GetComponent<TextMeshProUGUI>().text = "Tak";
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "Nie";
        }
    }
}
