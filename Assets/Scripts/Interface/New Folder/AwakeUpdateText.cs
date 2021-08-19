using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AwakeUpdateText : MonoBehaviour
{
    public UnityEvent updateText;
    public void Awake()
    {
        updateText.Invoke();

    }
}
