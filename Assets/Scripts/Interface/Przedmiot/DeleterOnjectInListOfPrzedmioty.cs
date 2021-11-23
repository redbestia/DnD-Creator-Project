using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterOnjectInListOfPrzedmioty : MonoBehaviour
{
    [SerializeField] ObjectInListReferencePrzedmiot _objectInListReference;

    public void DeleteObject()
    {
        _objectInListReference.PrzedmiotObiekt.Nazwa = "";

        GameObject.FindGameObjectWithTag(Tagi.SpawnerPrzedmiotTag).
            GetComponent<SpawnerPrzedmiot>().Spawn();
    }
}
