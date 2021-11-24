using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerCzar : MonoBehaviour
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

    PoziomCzaru _listOfCzary;
    TextMeshProUGUI[] _listOfTextMeshProUGUIs;

    public void Spawn()
    {
        ///Usuniêcie wszystkich KorzysciLubZdolnosci z Canvasa
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tagi.CzarTag);
        foreach (var item in gameObjects)
        {
            Destroy(item);
        }


        _listOfCzary = GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<PoziomCzaru>();

        //_listOfCzary.ListaCzarow.Sort();

        ///Sprawdzenie czy w liscie nie ma pustych nazw i usuwanie ich
        for (int j = 0; j < _listOfCzary.ListaCzarow.Count; j++)
        {
            if (_listOfCzary.ListaCzarow[j].Nazwa == "")
            {
                _listOfCzary.ListaCzarow.
                    Remove(_listOfCzary.ListaCzarow[j]);
                break;
            }
        }

        /// Stworzenie listy aby poznaæ d³ugoœæ ca³oœci
        float _height = 0;
        float allHeightForTlo = 0;

        int i = 0;

        foreach (var item in _listOfCzary.ListaCzarow)
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
                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarNazwaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarPoziomTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Poziom.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarCzasRzucaniaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.CzasRzucania.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarZasiegTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Zasieg.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarKomponentyTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Komponenty.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarCzasTrawniaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.CzasTrwania.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarOpisTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Opis;
                    _listOfTextMeshProUGUIs[j].GetComponent<ContentSizeFitter>().
                        SetLayoutVertical();


                    _height += _listOfTextMeshProUGUIs[j].preferredHeight;
                }
            }

            allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
            newCanvas.GetComponentInChildren<ObjectInListReferenceCzar>().CzarObiekt = item;
        }

        ///Dopasoanie wielkoœci i pozycji t³a i canvasa przesuwaj¹cego
        _tlo.sizeDelta = new Vector2(1800, _baseHeightTlo + allHeightForTlo);

        _canvasSkala.sizeDelta = new Vector2(_canvasSkala.sizeDelta.x,
            _baseHeightCanvasSkala + allHeightForTlo);

        _canvasSkala.localPosition = new Vector3(_canvasSkala.localPosition.x, -allHeightForTlo / 2 + 1000, 0);

        ///Usuniêcie testowej listy
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag(Tagi.CzarTag);
        foreach (var item in gameObjects2)
        {
            Destroy(item);
        }


        ///Stworzenie docelowej listy KorzysciLubZdolnosci w odpowiednim miejscu
        _height = 0;
        allHeightForTlo = 0;

        i = 0;

        foreach (var item in _listOfCzary.ListaCzarow)
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
                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarNazwaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarPoziomTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Poziom.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarCzasRzucaniaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.CzasRzucania.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarZasiegTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Zasieg.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarKomponentyTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Komponenty.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarCzasTrawniaTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.CzasTrwania.ToString();
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CzarOpisTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Opis;
                    _listOfTextMeshProUGUIs[j].GetComponent<ContentSizeFitter>().
                        SetLayoutVertical();


                    _height += _listOfTextMeshProUGUIs[j].preferredHeight;
                }
            }

            newCanvas.GetComponentInChildren<ObjectInListReferenceCzar>().CzarObiekt = item;
        }
    }
}
