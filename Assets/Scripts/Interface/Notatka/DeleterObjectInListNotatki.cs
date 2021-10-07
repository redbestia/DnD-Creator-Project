using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterObjectInListNotatki : MonoBehaviour
{
    [SerializeField] ObjectInListReferenceNotatka _objectInListReferenceNotatka;

    public void DeleteObject()
    {
        _objectInListReferenceNotatka.Notatka.NotatkaText = "";

        GameObject.FindGameObjectWithTag(Tagi.SpawnerNotatkaTag).
            GetComponent<Spawner_Notatki>().SpwanListOfNotatki();
    }
}
