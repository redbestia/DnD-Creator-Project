using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideMenu : MonoBehaviour
{
    [SerializeField] 
    Canvas _menuCanvas;
    public void ShowHide()
    {
        if (_menuCanvas.enabled)
            _menuCanvas.enabled = false;
        else
            _menuCanvas.enabled = true;
    }
}
