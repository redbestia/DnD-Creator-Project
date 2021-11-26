using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    [SerializeField] GameObject _data;
    void Awake()
    {
        SavesController.OdczytObiektow(_data);
    }

}
