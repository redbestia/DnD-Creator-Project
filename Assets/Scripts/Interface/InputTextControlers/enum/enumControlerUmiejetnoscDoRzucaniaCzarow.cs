using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class enumControlerUmiejetnoscDoRzucaniaCzarow : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] string _wybieracz = "";

    public void WyswietlUmiejetnosc()
    {
        switch (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow)
        {
            case UmiejetnoscDoRzucaniaCzarowWybor.Charyzma:
                _text.text = "Charyzma";
                break;
            case UmiejetnoscDoRzucaniaCzarowWybor.Madrosc:
                _text.text = "M¹droœæ";
                break;
            case UmiejetnoscDoRzucaniaCzarowWybor.Inteligencja:
                _text.text = "Inteligencja";
                break;
            default:
                Debug.LogError("Brak wyboru charakteru");
                break;
        }
    }


        public void UstawOdpowiedniaUmiejetnosc()
        {
            switch (_wybieracz)
            {
                case "3":
                    GameObject.FindGameObjectWithTag(Tagi.DataTag).
            GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow = UmiejetnoscDoRzucaniaCzarowWybor.Charyzma;
                    break;
                case "2":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).
        GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow = UmiejetnoscDoRzucaniaCzarowWybor.Madrosc;
                break;
                case "1":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).
        GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>().UmiejetnoscDoRzucaniaCzarow = UmiejetnoscDoRzucaniaCzarowWybor.Inteligencja;
                break;
                default:
                    Debug.LogError("Brak wyboru charakteru");
                    break;
            }
        }

    }
