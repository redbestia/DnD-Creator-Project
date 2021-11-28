using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterObjectInListOfBron : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceBron _objectInListReference;

    public void DeleteObject()
    {
        _objectInListReference.BronReference.Nazwa = "";

        GameObject.FindGameObjectWithTag(Tagi.SpawnerBronTag).
            GetComponent<SpawnerBron>().Spawn();
    }
}
