using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsControler : MonoBehaviour
{
    [SerializeField] Canvas CanvasToShow;

    public void DisplayMenuCanvas()
    {
        foreach (var item in CollectAllMenuCanvas.ListOfMemuCanvas)
        {
            item.GetComponent<Canvas>().enabled = false;
        }
        CanvasToShow.enabled = true;
    }
}
