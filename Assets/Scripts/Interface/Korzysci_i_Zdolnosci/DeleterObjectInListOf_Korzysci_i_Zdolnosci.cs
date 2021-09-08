using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleterObjectInListOf_Korzysci_i_Zdolnosci : MonoBehaviour
{
    [SerializeField] ObjectInListReference _objectInListReference;

    public void DeleteObject()
    {
        _objectInListReference.KorzyscLubZdolnosc.Nazwa = "";

        GameObject.FindGameObjectWithTag(Tagi.SpawnerKorzyscLubZdolnoscTag).
            GetComponent<Spawner_Korzysci_Zdolnosci>().SpwanListOfKorzysci_i_Zdolnosci();
    }
}
