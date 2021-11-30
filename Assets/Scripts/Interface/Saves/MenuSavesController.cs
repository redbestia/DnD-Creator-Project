using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class MenuSavesController : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _menuDataContainer;
    public static int idNowejPostaci;

    public List<GameObject> lista = new List<GameObject>();

    public UnityEvent OnStartLoad;
    void Start()
    {
        idNowejPostaci = 0;

        foreach (string file in Directory.GetFiles(Application.dataPath))
        {

            if (file.EndsWith(".json"))
            {
                idNowejPostaci++;

                GameObject obiekt = Instantiate(_prefab);
                obiekt.transform.SetParent(_menuDataContainer);

                string json = File.ReadAllLines(file)[0];
                JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
                json = File.ReadAllLines(file)[1];
                JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GornyPanelData>());
                lista.Add(obiekt);
            }

        }
        OnStartLoad.Invoke();
    }
}

