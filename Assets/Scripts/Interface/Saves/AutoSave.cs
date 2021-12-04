using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    [SerializeField] GameObject _data;
    void Start()
    {
        StartCoroutine(ExampleCoroutine(_data));
    }

    IEnumerator ExampleCoroutine(GameObject data)
    {
        yield return new WaitForSeconds(5);
        SavesController.ZapisObiektu(data);
        StartCoroutine(ExampleCoroutine(data));
    }

    private void OnApplicationPause(bool pause)
    {
        SavesController.ZapisObiektu(_data);
    }

    private void OnApplicationQuit()
    {
        SavesController.ZapisObiektu(_data);
    }
}
