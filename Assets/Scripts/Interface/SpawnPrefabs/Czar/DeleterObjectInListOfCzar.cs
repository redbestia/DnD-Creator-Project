using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterObjectInListOfCzar : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceCzar _objectInListReference;

    public void DeleteObject()
    {
        _objectInListReference.CzarObiekt.Nazwa = "";

        GameObject.FindGameObjectWithTag(Tagi.SpawnerCzarTag).
            GetComponent<SpawnerCzar>().Spawn();
    }
}
