using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZmianaKoloruPic : MonoBehaviour
{
    RawImage _image;

    private void Awake()
    {
        _image = GetComponent<RawImage>();
    }
    public void ZmienNaCzarny()
    {
        _image.color = Color.black;
    }
    public void ZmienNaBialy()
    {
        _image.color = Color.white;

    }
}
