using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;


public class SavesController : MonoBehaviour
{
    public static void ZapisObiektu(GameObject obiekt)
    {

        string idPostaci = obiekt.GetComponent<IDPostaci>().ID.ToString();
        string path = Application.dataPath + "/" + idPostaci + ".json";

        string json = JsonUtility.ToJson(obiekt.GetComponent<EkwipunekData>());
        File.WriteAllText(path, json + "\n");
        //foreach (var czar in obiekt.GetComponent<PoziomCzaru>().ListaCzarow)
        //{
        //    json = JsonUtility.ToJson(czar);
        //    File.AppendAllText(path, json);
        //}
        json = JsonUtility.ToJson(obiekt.GetComponent<PoziomCzaru>());        //tutaj foreach
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<Notatki>());        //tutaj foreach
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<Poziom>());        //tutaj foreach
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<KlasaPancerzaISzybkosc>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<ListaBroni>());        //tutaj foreach
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<RzutyPrzeciwSmierci>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<Bieglosci>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<GlowneStatystyki>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<GornyPanelData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<OpisData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<RzutyObronneData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<UmiejetnosciData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<IDPostaci>());
        File.AppendAllText(path, json);
    }



    public static void OdczytObiektow(GameObject obiekt)
    {
        string idPostaci = IDController.IDDoWysylki.ToString();
        string path = Application.dataPath + "/" + idPostaci + ".json";

        if(File.ReadAllLines(path).Length != 1)
        {
            //do odczytu istniej¹ceje postaci
            string json = File.ReadAllLines(path)[0];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<EkwipunekData>());
            json = File.ReadAllLines(path)[1];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<PoziomCzaru>());
            json = File.ReadAllLines(path)[2];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>());
            json = File.ReadAllLines(path)[3];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Notatki>());
            json = File.ReadAllLines(path)[4];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Poziom>());
            json = File.ReadAllLines(path)[5];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<KlasaPancerzaISzybkosc>());
            json = File.ReadAllLines(path)[6];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<ListaBroni>());
            json = File.ReadAllLines(path)[7];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<RzutyPrzeciwSmierci>());
            json = File.ReadAllLines(path)[8];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Bieglosci>());
            json = File.ReadAllLines(path)[9];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GlowneStatystyki>());
            json = File.ReadAllLines(path)[10];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GornyPanelData>());
            json = File.ReadAllLines(path)[11];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<OpisData>());
            json = File.ReadAllLines(path)[12];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<RzutyObronneData>());
            json = File.ReadAllLines(path)[13];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<UmiejetnosciData>());
            json = File.ReadAllLines(path)[14];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
        }
        else
        {
            //do odczytu nowej postaci
            string json = File.ReadAllLines(path)[0];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
        }
    }        
}
