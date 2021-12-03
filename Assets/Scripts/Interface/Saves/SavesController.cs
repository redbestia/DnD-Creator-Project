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
        //string path = Application.dataPath + "/" + idPostaci + ".json";

        string path = (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.IPhonePlayer ?
            Application.persistentDataPath : Application.dataPath) + "/" + idPostaci + ".json";

        string json = JsonUtility.ToJson(obiekt.GetComponent<IDPostaci>());
        File.WriteAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<GornyPanelData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<EkwipunekData>());
        File.AppendAllText(path, json + "\n");
        //Pocz¹tek
        json = "";
        foreach (var item in obiekt.GetComponent<EkwipunekData>().ListaPrzedmiotow)
        {
            json = JsonUtility.ToJson(item);
            File.AppendAllText(path, json + "\n");
        }
        File.AppendAllText(path, "przerwa1\n");
        //Koniec
        json = JsonUtility.ToJson(obiekt.GetComponent<PoziomCzaru>());
        File.AppendAllText(path, json + "\n");
        //Pocz¹tek
        json = "";
        foreach (var item in obiekt.GetComponent<PoziomCzaru>().ListaCzarow)
        {
            json = JsonUtility.ToJson(item);
            File.AppendAllText(path, json + "\n");
        }
        File.AppendAllText(path, "przerwa2\n");
        //Koniec
        json = JsonUtility.ToJson(obiekt.GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<Notatki>()); 
        File.AppendAllText(path, json + "\n");
        //Pocz¹tek
        json = "";
        foreach (var item in obiekt.GetComponent<Notatki>().ListaNotatek)
        {
            json = JsonUtility.ToJson(item);
            File.AppendAllText(path, json + "\n");
        }
        File.AppendAllText(path, "przerwa3\n");
        //Koniec
        json = JsonUtility.ToJson(obiekt.GetComponent<Poziom>());  
        File.AppendAllText(path, json + "\n");
        //Pocz¹tek
        json = "";
        foreach (var item in obiekt.GetComponent<Poziom>().ListaKorzysciAndZdolnosci)
        {
            json = JsonUtility.ToJson(item);
            File.AppendAllText(path, json + "\n");
        }
        File.AppendAllText(path, "przerwa4\n");
        //Koniec
        json = JsonUtility.ToJson(obiekt.GetComponent<KlasaPancerzaISzybkosc>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<ListaBroni>());  
        File.AppendAllText(path, json + "\n");
        //Pocz¹tek
        json = "";
        foreach (var item in obiekt.GetComponent<ListaBroni>().PosiadaneBronie)
        {
            json = JsonUtility.ToJson(item);
            File.AppendAllText(path, json + "\n");
        }
        File.AppendAllText(path, "przerwa5\n");
        //Koniec
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<RzutyPrzeciwSmierci>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<Bieglosci>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<GlowneStatystyki>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<OpisData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<RzutyObronneData>());
        File.AppendAllText(path, json + "\n");
        json = JsonUtility.ToJson(obiekt.GetComponent<UmiejetnosciData>());
        File.AppendAllText(path, json + "\n");
    }



    public static void OdczytObiektow(GameObject obiekt)
    {
        string idPostaci = IDController.IDDoWysylki.ToString();
        //string path = Application.dataPath + "/" + idPostaci + ".json";

        string path = (Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.IPhonePlayer ?
            Application.persistentDataPath : Application.dataPath) + "/" + idPostaci + ".json";

        if (File.ReadAllLines(path).Length != 1)
        {
            int i = 0;
            string json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GornyPanelData>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<EkwipunekData>());
            i++;
            //Pocz¹tek grzebania w liœcie
            obiekt.GetComponent<EkwipunekData>().ListaPrzedmiotow.Clear();
            json = File.ReadAllLines(path)[i];
            while (json != "przerwa1")
            {
                Przedmiot item = ScriptableObject.CreateInstance("Przedmiot") as Przedmiot;
                JsonUtility.FromJsonOverwrite(json, item);
                obiekt.GetComponent<EkwipunekData>().ListaPrzedmiotow.Add(item);
                i++;
                json = File.ReadAllLines(path)[i];
            }
            i++;
            //Koniec
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<PoziomCzaru>());
            i++;
            //Pocz¹tek grzebania w liœcie
            obiekt.GetComponent<PoziomCzaru>().ListaCzarow.Clear();
            json = File.ReadAllLines(path)[i];
            while (json != "przerwa2")
            {
                Czar item2 = ScriptableObject.CreateInstance("Czar") as Czar;
                JsonUtility.FromJsonOverwrite(json, item2);
                obiekt.GetComponent<PoziomCzaru>().ListaCzarow.Add(item2);
                i++;
                json = File.ReadAllLines(path)[i];
            }
            i++;
            //Koniec
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<UmiejetnoscDoRzucaniaCzarowKlasa>());
            i++;

            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Notatki>());
            i++;
            //Pocz¹tek grzebania w liœcie
            obiekt.GetComponent<Notatki>().ListaNotatek.Clear();
            json = File.ReadAllLines(path)[i];
            while (json != "przerwa3")
            {
                Notatka item3 = ScriptableObject.CreateInstance("Notatka") as Notatka;
                JsonUtility.FromJsonOverwrite(json, item3);
                obiekt.GetComponent<Notatki>().ListaNotatek.Add(item3);
                i++;
                json = File.ReadAllLines(path)[i];
            }
            i++;
            //Koniec


            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Poziom>());
            i++;
            //Pocz¹tek grzebania w liœcie
            obiekt.GetComponent<Poziom>().ListaKorzysciAndZdolnosci.Clear();
            json = File.ReadAllLines(path)[i];
            while (json != "przerwa4")
            {
                KorzyscLubZdolnosc item4 = ScriptableObject.CreateInstance("KorzyscLubZdolnosc") as KorzyscLubZdolnosc;
                JsonUtility.FromJsonOverwrite(json, item4);
                obiekt.GetComponent<Poziom>().ListaKorzysciAndZdolnosci.Add(item4);
                i++;
                json = File.ReadAllLines(path)[i];
            }
            i++;
            //Koniec
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<KlasaPancerzaISzybkosc>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<ListaBroni>());




            i++;
            //Pocz¹tek grzebania w liœcie
            obiekt.GetComponent<ListaBroni>().PosiadaneBronie.Clear();
            json = File.ReadAllLines(path)[i];
            while (json != "przerwa5")
            {
                Bron item = ScriptableObject.CreateInstance("Bron") as Bron;
                JsonUtility.FromJsonOverwrite(json, item);
                obiekt.GetComponent<ListaBroni>().PosiadaneBronie.Add(item);
                i++;
                json = File.ReadAllLines(path)[i];
            }
            i++;
            //Koniec
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<RzutyPrzeciwSmierci>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<Bieglosci>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<GlowneStatystyki>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<OpisData>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<RzutyObronneData>());
            i++;
            json = File.ReadAllLines(path)[i];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<UmiejetnosciData>());
            i++;
        }
        else
        {

            string json = File.ReadAllLines(path)[0];
            JsonUtility.FromJsonOverwrite(json, obiekt.GetComponent<IDPostaci>());
        }
    }
}



