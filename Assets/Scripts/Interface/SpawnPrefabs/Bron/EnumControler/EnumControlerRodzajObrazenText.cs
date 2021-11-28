using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnumControlerRodzajObrazenText : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;
    public void PobierzText()
    {
        if (_objectInListReference.BronReference.RodzajObrazen == RodzajObrazen.Ciete)
        {
            GetComponent<TextMeshProUGUI>().text = "Ciête";
        }
        else if (_objectInListReference.BronReference.RodzajObrazen == RodzajObrazen.Kute)
        {
            GetComponent<TextMeshProUGUI>().text = "Kute";
        }
        else if (_objectInListReference.BronReference.RodzajObrazen == RodzajObrazen.Obuchowe)
        {
            GetComponent<TextMeshProUGUI>().text = "Obuchowe";
        }
    }
}
