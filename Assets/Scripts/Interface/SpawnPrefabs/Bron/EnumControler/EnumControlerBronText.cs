using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnumControlerBronText : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;
    public void PobierzText()
    {
        if (_objectInListReference.BronReference.RodzajBroni == RodzajBroni.Bia³a)
        {
            GetComponent<TextMeshProUGUI>().text = "Bia³a";
        }
        else if (_objectInListReference.BronReference.RodzajBroni == RodzajBroni.Dystansowa)
        {
            GetComponent<TextMeshProUGUI>().text = "Dystansowa";
        }
        else if (_objectInListReference.BronReference.RodzajBroni == RodzajBroni.Finezyjna)
        {
            GetComponent<TextMeshProUGUI>().text = "Finezyjna";
        }
    }
}
