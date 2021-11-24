using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewCharacterCreator : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    //to se komentujesz
    public int wybraneID = 0;
    public void TworzeniePostaci()
    {
        IDController.IDDoWysylki = MenuSavesController.idNowejPostaci;
        _prefab.GetComponent<IDPostaci>().ID = IDController.IDDoWysylki;

        string idPostaci = _prefab.GetComponent<IDPostaci>().ID.ToString();
        string path = Application.dataPath + "/" + idPostaci + ".json";

        string json = JsonUtility.ToJson(_prefab.GetComponent<IDPostaci>());
        File.WriteAllText(path, json);
    }

    //tu se robisz statica i potrzebujesz w metodzie przyj¹æ wybraneID
    public void WyborPostaci()
    {
        IDController.IDDoWysylki = wybraneID;
    }


}
