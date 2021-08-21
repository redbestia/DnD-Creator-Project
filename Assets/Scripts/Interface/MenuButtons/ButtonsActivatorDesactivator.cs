using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsActivatorDesactivator : MonoBehaviour
{
    [SerializeField]
    List<Button> _listButton;
    public void ActivateDesactivate()
    {
        if (_listButton[0].interactable == true)
            foreach (var item in _listButton)
            {
                item.interactable = false;
            }
        else
            foreach (var item in _listButton)
            {
                item.interactable = true;
            }
    }

}
