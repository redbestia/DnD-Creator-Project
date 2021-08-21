using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZmianaKoloru : MonoBehaviour
{
    Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    public void ZmienNaCzarny()
    {
        _button.image.color = Color.black;
    }
    public void ZmienNaBialy()
    {
        _button.image.color = Color.white;
    
    }
}
