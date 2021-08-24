using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextControlerGlowneStatystykiZrecznosc : MonoBehaviour
{

    public void PobierzText()
    {
        GetComponent<TextMeshProUGUI>().text = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().Modfikator
               (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>().zrecznosc).ToString();
    }

}
