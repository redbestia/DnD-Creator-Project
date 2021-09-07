using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZmianaPołożenia : MonoBehaviour
{
    Canvas _canvas;
    [SerializeField] float polozenie = 0;

    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
    }
    public void ZmienPolozenieCanvasa()
    {
        _canvas.GetComponent<RectTransform>().
            position = new Vector3(_canvas.GetComponent<RectTransform>().
            position.x, polozenie, _canvas.GetComponent<RectTransform>().
            position.z);

        _canvas.GetComponent<ScrollRect>().velocity = new Vector3(0, 0, 0);
    }
}