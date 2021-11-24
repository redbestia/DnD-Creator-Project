using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MenuSavesController : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _menuDataContainer;
    public static int idNowejPostaci;

    public List<GameObject> lista = new List<GameObject>();
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
                
                string json = File.ReadAllLines(file)[10];
                JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GornyPanelData>());
                json = File.ReadAllLines(file)[14];
                JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
                lista.Add(obiekt);
            }

        }

    }
}

