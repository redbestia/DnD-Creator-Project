using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonsControler : MonoBehaviour
{
    [SerializeField] Canvas CanvasToShow;

    public void DisplayMenuCanvas()
    {
        foreach (var item in CollectAllMenuCanvas.ListOfMemuCanvas)
        {
            item.GetComponent<Canvas>().sortingOrder = 0;


          item.GetComponent<Canvas>().enabled = false;
            if (item.GetComponent<ScrollRect>() != null)
            {
                item.GetComponent<ScrollRect>().enabled = false;
            }

        }
        CanvasToShow.GetComponent<Canvas>().sortingOrder = 1;
        CanvasToShow.enabled = true;
        if (CanvasToShow.GetComponent<ScrollRect>() != null)
        {
            CanvasToShow.GetComponent<ScrollRect>().enabled = true;
        }
    }
}
