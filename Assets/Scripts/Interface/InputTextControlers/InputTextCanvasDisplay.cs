using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTextCanvasDisplay : MonoBehaviour
{
    public void ShowCanvas()
    {
        GetComponent<Canvas>().enabled = true;
    }
    public void HideCanvas()
    {
        GetComponent<Canvas>().enabled = false;
    }
    public void test ()
    {
        Debug.Log("jo³");
    }

    public void SetCanvasMiddle()
    {
        transform.position = new Vector2(600, 1400);
    }
}
