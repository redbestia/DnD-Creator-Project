using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class enumControlerOpisDataCharakter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] string _wybieracz = "";

    public void WyswietlCharakter()
    {
        switch (GameObject.
            FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter)
        {
            case CharakterWybor.PraworzadnyDobry:
                _text.text = "Praworz¹dny Dobry";
                break;
            case CharakterWybor.NeutralnyDobry:
                _text.text = "Neutralny Dobry";
                break;
            case CharakterWybor.ChaotycznyDobry:
                _text.text = "Chaotyczny Dobry";
                break;
            case CharakterWybor.PraworzadnyNeutralny:
                _text.text = "Praworz¹dny Neutralny";
                break;
            case CharakterWybor.Neutralny:
                _text.text = "Neutralny";
                break;
            case CharakterWybor.ChaotycznyNeutralny:
                _text.text = "Chaotyczny Neutralny";
                break;
            case CharakterWybor.PraworzadnyZly:
                _text.text = "Praworz¹dny Z³y";
                break;
            case CharakterWybor.NeutralnyZly:
                _text.text = "Neutralny Z³y";
                break;
            case CharakterWybor.ChaotycznyZly:
                _text.text = "Chaotyczny Z³y";
                break;
            default: Debug.LogError("Brak wyboru charakteru");
                break;
        }
    }


    public void UstawOdpowiedniCharakter()
    {
        switch (_wybieracz)
        {
            case "1":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.PraworzadnyDobry;
                break;
            case "2":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.NeutralnyDobry;
                break;
            case "3":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.ChaotycznyDobry;
                break;
            case "4":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.PraworzadnyNeutralny;
                break;
            case "5":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.Neutralny;
                break;
            case "6":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.ChaotycznyNeutralny;
                break;
            case "7":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.PraworzadnyZly;
                break;
            case "8":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.NeutralnyZly;
                break;
            case "9":
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<OpisData>().Charakter = CharakterWybor.ChaotycznyZly;
                break;
            default: Debug.LogError("Brak wyboru charakteru");
                break;
        }
    }










}
