using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EditNotatka : MonoBehaviour
{
    [SerializeField] TMP_InputField _opisInputField;
    [SerializeField] ObjectInListReferenceNotatka _objectInListReference;

    public void Edit_Notatka()
    {
        _objectInListReference.Notatka.NotatkaText = _opisInputField.text;

        GameObject.FindGameObjectWithTag(Tagi.SpawnerNotatkaTag).
            GetComponent<Spawner_Notatki>().SpwanListOfNotatki();
    }
}
