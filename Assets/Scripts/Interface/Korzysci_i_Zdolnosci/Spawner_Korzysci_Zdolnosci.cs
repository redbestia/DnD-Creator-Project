using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Spawner_Korzysci_Zdolnosci : MonoBehaviour
{
    [SerializeField] Canvas _prefab;
    [SerializeField] RectTransform _canvasKorzysciZdolnosci;

    [SerializeField] float _xDefaultSpawn = 620;
    [SerializeField] float _yDefaultSpawn = 720;
    [SerializeField] float _yAddedHeight = 200;



    Poziom _listOfKorzysciZdolnosci;
    TextMeshProUGUI[] _listOfTextMeshProUGUIs;

    

    public void SpwanListOfKorzysci_i_Zdolnosci()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tagi.KorzyscLubZdolnoscTag);
        foreach (var item in gameObjects)
        {
            Destroy(item);
        }

        _listOfKorzysciZdolnosci = GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<Poziom>();

        _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci.Sort();




        float _height = 0;
        int i = 0;

        foreach (var item in _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci)
        {
            Canvas newCanvas = Instantiate(_prefab);
            

            newCanvas.transform.SetParent(_canvasKorzysciZdolnosci);


            float ySpawn = _yDefaultSpawn - _height - (_yAddedHeight * i);
            i++;
            newCanvas.GetComponent<RectTransform>().position = 
                new Vector3(_xDefaultSpawn, ySpawn, 0);

            _listOfTextMeshProUGUIs = newCanvas.GetComponentsInChildren<TextMeshProUGUI>();

            for (int j = 0; j < _listOfTextMeshProUGUIs.Length; j++)
            {
                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataNazwaTextTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataPoziomTextTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.level.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataOpisTextTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Opis;
                    _listOfTextMeshProUGUIs[j].GetComponent<ContentSizeFitter>().
                        SetLayoutVertical();
                    

                    _height += _listOfTextMeshProUGUIs[j].preferredHeight;
                }
            }
        }


    }
}
