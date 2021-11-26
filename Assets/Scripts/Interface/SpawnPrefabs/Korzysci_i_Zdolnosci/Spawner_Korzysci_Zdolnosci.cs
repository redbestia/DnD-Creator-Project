using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Spawner_Korzysci_Zdolnosci : MonoBehaviour
{
    [SerializeField] Canvas _prefab;
    [SerializeField] RectTransform _canvasLista;
    [SerializeField] RectTransform _tlo;
    [SerializeField] RectTransform _canvasSkala;

    [SerializeField] float _xDefaultSpawn = 620;
    [SerializeField] float _yDefaultSpawn = 720;
    [SerializeField] float _yAddedHeight = 200;
    [SerializeField] float _baseHeightTlo = 4700;
    [SerializeField] float _baseHeightCanvasSkala = 2000;

    Poziom _listOfKorzysciZdolnosci;
    TextMeshProUGUI[] _listOfTextMeshProUGUIs;

    public void SpwanListOfKorzysci_i_Zdolnosci()
    {
        ///Usuniêcie wszystkich KorzysciLubZdolnosci z Canvasa
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tagi.KorzyscLubZdolnoscTag);
        foreach (var item in gameObjects)
        {
            Destroy(item);
        }


        _listOfKorzysciZdolnosci = GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<Poziom>();

        _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci.Sort();

        ///Sprawdzenie czy w liscie nie ma pustych nazw i usuwanie ich
        for (int j = 0; j < _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci.Count; j++)
        {
            if (_listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci[j].Nazwa == "")
            {
                _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci.
                    Remove(_listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci[j]);
                break;
            }
        }

        /// Stworzenie listy aby poznaæ d³ugoœæ ca³oœci
        float _height = 0;
        float allHeightForTlo = 0;

        int i = 0;

        foreach (var item in _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci)
        {
            

            Canvas newCanvas = Instantiate(_prefab);

            newCanvas.transform.SetParent(_canvasLista);


            float ySpawn = _yDefaultSpawn - _height - (_yAddedHeight * i);
            allHeightForTlo = _height + _yDefaultSpawn  + (_yAddedHeight * i);
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

            allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
            newCanvas.GetComponentInChildren<ObjectInListReference>().KorzyscLubZdolnosc = item;
        }

        ///Dopasoanie wielkoœci i pozycji t³a i canvasa przesuwaj¹cego
        _tlo.sizeDelta = new Vector2(1800, _baseHeightTlo + allHeightForTlo);

        _canvasSkala.sizeDelta = new Vector2(_canvasSkala.sizeDelta.x,
            _baseHeightCanvasSkala + allHeightForTlo);

         _canvasSkala.localPosition = new Vector3(_canvasSkala.localPosition.x, -allHeightForTlo/2 + 1000, 0);

        ///Usuniêcie testowej listy
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag(Tagi.KorzyscLubZdolnoscTag);
        foreach (var item in gameObjects2)
        {
            Destroy(item);
        }


        ///Stworzenie docelowej listy KorzysciLubZdolnosci w odpowiednim miejscu
        _height = 0;
         allHeightForTlo = 0;

         i = 0;

        foreach (var item in _listOfKorzysciZdolnosci.ListaKorzysciAndZdolnosci)
        {


            Canvas newCanvas = Instantiate(_prefab);

            newCanvas.transform.SetParent(_canvasLista);


            float ySpawn = _yDefaultSpawn - _height - (_yAddedHeight * i);
            allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
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


            newCanvas.GetComponentInChildren<ObjectInListReference>().KorzyscLubZdolnosc = item;
        }


    }
}
