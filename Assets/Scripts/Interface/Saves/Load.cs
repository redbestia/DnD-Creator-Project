using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    [SerializeField] GameObject _data;
    void Start()
    {
        SavesController.OdczytObiektow(_data);
    }

}
