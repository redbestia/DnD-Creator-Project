using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerPrzedmiot : MonoBehaviour
{
  
        [SerializeField] Canvas _prefab;
        [SerializeField] RectTransform _canvasLista;
        [SerializeField] RectTransform _tlo;
        [SerializeField] RectTransform _canvasSkala;

        [SerializeField] float _xDefaultSpawn = 620;
        [SerializeField] float _yDefaultSpawn = 720;
        [SerializeField] float _yAddedHeight = 200;
        [SerializeField] float _baseHeightTlo = 4700;
        [SerializeField] float _baseHeightCanvasSkala = 0;

        EkwipunekData _listOfPrzedmioty;
        TextMeshProUGUI[] _listOfTextMeshProUGUIs;

        public void Spawn()
        {
            ///Usuniêcie wszystkich Notatek z Canvasa
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tagi.PrzedmiotTag);
            foreach (var item in gameObjects)
            {
                Destroy(item);
            }


            _listOfPrzedmioty = GameObject.FindGameObjectWithTag(Tagi.DataTag).
                GetComponent<EkwipunekData>();

            //_listOfNotatki.ListaNotatek.Sort();

            ///Sprawdzenie czy w liscie nie ma pustych nazw i usuwanie ich
            for (int j = 0; j < _listOfPrzedmioty.ListaPrzedmiotow.Count; j++)
            {
                if (_listOfPrzedmioty.ListaPrzedmiotow[j].Nazwa == "")
                {
                    _listOfPrzedmioty.ListaPrzedmiotow.
                        Remove(_listOfPrzedmioty.ListaPrzedmiotow[j]);
                    break;
                }
            }

            /// Stworzenie listy aby poznaæ d³ugoœæ ca³oœci
            float _height = 0;
            float allHeightForTlo = 0;

            int i = 0;

            foreach (var item in _listOfPrzedmioty.ListaPrzedmiotow)
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
                    if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataPrzedmiotNazwaTextTag))
                    {
                        _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                    }
                    if(_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataPrzedmiotIloscTextTag))
                    {
                        _listOfTextMeshProUGUIs[j].text = item.Ilosc.ToString();
                    }
                }

                allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
                newCanvas.GetComponentInChildren<ObjectInListReferencePrzedmiot>().PrzedmiotObiekt = item;
            }

            ///Dopasoanie wielkoœci i pozycji t³a i canvasa przesuwaj¹cego
            _tlo.sizeDelta = new Vector2(1800, _baseHeightTlo + allHeightForTlo);

            _canvasSkala.sizeDelta = new Vector2(_canvasSkala.sizeDelta.x,
                _baseHeightCanvasSkala + allHeightForTlo);

            _canvasSkala.localPosition = new Vector3(_canvasSkala.localPosition.x, 
                -allHeightForTlo / 2 + 1000, 0);

            ///Usuniêcie testowej listy
            GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag(Tagi.PrzedmiotTag);
            foreach (var item in gameObjects2)
            {
                Destroy(item);
            }


            ///Stworzenie docelowej listy KorzysciLubZdolnosci w odpowiednim miejscu
            _height = 0;
            allHeightForTlo = 0;

            i = 0;

            foreach (var item in _listOfPrzedmioty.ListaPrzedmiotow)
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
                    if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataPrzedmiotNazwaTextTag))
                    {
                        _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                    }
                    if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.DataPrzedmiotIloscTextTag))
                    {
                        _listOfTextMeshProUGUIs[j].text = item.Ilosc.ToString();
                    }
                }

                allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
                newCanvas.GetComponentInChildren<ObjectInListReferencePrzedmiot>().PrzedmiotObiekt = item;
            }


        }
    

}
