using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerBron : MonoBehaviour
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

    ListaBroni _listOfBronie;
    TextMeshProUGUI[] _listOfTextMeshProUGUIs;
    GlowneStatystyki _data;

    private void Awake()
    {
        _data = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<GlowneStatystyki>();
    }

    public void Spawn()
    {
        ///Usuniêcie wszystkich Notatek z Canvasa
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(Tagi.PrzedmiotTag);
        foreach (var item in gameObjects)
        {
            Destroy(item);
        }


        _listOfBronie = GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<ListaBroni>();

        //_listOfNotatki.ListaNotatek.Sort();

        ///Sprawdzenie czy w liscie nie ma pustych nazw i usuwanie ich
        for (int j = 0; j < _listOfBronie.PosiadaneBronie.Count; j++)
        {
            if (_listOfBronie.PosiadaneBronie[j].Nazwa == "")
            {
                _listOfBronie.PosiadaneBronie.
                    Remove(_listOfBronie.PosiadaneBronie[j]);
                break;
            }
        }

        /// Stworzenie listy aby poznaæ d³ugoœæ ca³oœci
        float _height = 0;
        float allHeightForTlo = 0;

        int i = 0;

        foreach (var item in _listOfBronie.PosiadaneBronie)
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
                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.NazwaBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CelnoscBronTag))
                {
                    int bieglosc = 0;
                    if (item.CzyBieglosc)
                        bieglosc = _data.bieglosc;

                    if(item.RodzajBroni == RodzajBroni.Bia³a)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila + bieglosc).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Dystansowa)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc + bieglosc).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Finezyjna)
                    {
                        if (_data.zrecznosc > _data.sila)
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc + bieglosc).ToString();
                        }
                        else
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila + bieglosc).ToString();
                        }
                    }
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.RodzajObrazenBronTag))
                {
                    if (item.RodzajObrazen == RodzajObrazen.Ciete)
                        _listOfTextMeshProUGUIs[j].text = "Ciête";
                    else if(item.RodzajObrazen == RodzajObrazen.Kute)
                        _listOfTextMeshProUGUIs[j].text = "Kute";
                    else if (item.RodzajObrazen == RodzajObrazen.Obuchowe)
                        _listOfTextMeshProUGUIs[j].text = "Obuchowe";
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.ObrazeniaBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Obrazenia;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.PlusObrazeniaBronTag))
                {
                    if (item.RodzajBroni == RodzajBroni.Bia³a)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Dystansowa)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc ).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Finezyjna)
                    {
                        if (_data.zrecznosc > _data.sila)
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc ).ToString();
                        }
                        else
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila).ToString();
                        }
                    }
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.OpisBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Opis;
                }
            }

            allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
            newCanvas.GetComponentInChildren<ObjectInListReferenceBron>().BronReference = item;
        }

        ///Dopasoanie wielkoœci i pozycji t³a i canvasa przesuwaj¹cego
        _tlo.sizeDelta = new Vector2(1800, _baseHeightTlo + allHeightForTlo);

        _canvasSkala.sizeDelta = new Vector2(_canvasSkala.sizeDelta.x, 
            _baseHeightCanvasSkala + allHeightForTlo);

        _canvasSkala.localPosition = new Vector3(_canvasSkala.localPosition.x,
            -allHeightForTlo / 2 + 1000, 0);

        ///Usuniêcie testowej listy
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag(Tagi.BronTag);
        foreach (var item in gameObjects2)
        {
            Destroy(item);
        }


        ///Stworzenie docelowej listy KorzysciLubZdolnosci w odpowiednim miejscu
        _height = 0;
        allHeightForTlo = 0;

        i = 0;

        foreach (var item in _listOfBronie.PosiadaneBronie)
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
                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.NazwaBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Nazwa;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.CelnoscBronTag))
                {
                    int bieglosc = 0;
                    if (item.CzyBieglosc)
                        bieglosc = _data.bieglosc;

                    if (item.RodzajBroni == RodzajBroni.Bia³a)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila + bieglosc).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Dystansowa)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc + bieglosc).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Finezyjna)
                    {
                        if (_data.zrecznosc > _data.sila)
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc + bieglosc).ToString();
                        }
                        else
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila + bieglosc).ToString();
                        }
                    }
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.RodzajObrazenBronTag))
                {
                    if (item.RodzajObrazen == RodzajObrazen.Ciete)
                        _listOfTextMeshProUGUIs[j].text = "Ciête";
                    else if (item.RodzajObrazen == RodzajObrazen.Kute)
                        _listOfTextMeshProUGUIs[j].text = "Kute";
                    else if (item.RodzajObrazen == RodzajObrazen.Obuchowe)
                        _listOfTextMeshProUGUIs[j].text = "Obuchowe";
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.ObrazeniaBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Obrazenia;
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.PlusObrazeniaBronTag))
                {
                    if (item.RodzajBroni == RodzajBroni.Bia³a)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Dystansowa)
                    {
                        _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc).ToString();
                    }
                    else if (item.RodzajBroni == RodzajBroni.Finezyjna)
                    {
                        if (_data.zrecznosc > _data.sila)
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.zrecznosc).ToString();
                        }
                        else
                        {
                            _listOfTextMeshProUGUIs[j].text = GlowneStatystyki.
                            ModfikatorStatic(_data.sila).ToString();
                        }
                    }
                }

                if (_listOfTextMeshProUGUIs[j].CompareTag(Tagi.OpisBronTag))
                {
                    _listOfTextMeshProUGUIs[j].text = item.Opis;
                }
            }

            allHeightForTlo = _height + _yDefaultSpawn + (_yAddedHeight * i);
            newCanvas.GetComponentInChildren<ObjectInListReferenceBron>().BronReference = item;
        }
    }
}
