using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DeleteCharacter : MonoBehaviour
{
    [SerializeField] GameObject ObjectReference;
    public void UsunPostac()
    {
        //MenuSavesController.idNowejPostaci = 0;
        //bool przestawacz = false;

        File.Delete((Application.platform == RuntimePlatform.Android ||
            Application.platform == RuntimePlatform.IPhonePlayer ?
            Application.persistentDataPath : Application.dataPath) + "/" + ObjectReference.GetComponent<ObjectInListReferencePostac>().ID.ID.ToString() + ".json");

        for (int i = 0; i < GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<MenuSavesController>().lista.Count; i++)
        {
            //if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<MenuSavesController>().lista[i].GetComponent<IDPostaci>().ID != MenuSavesController.idNowejPostaci)
            //{
            //    przestawacz = true;
            //}

            //if (przestawacz == false) MenuSavesController.idNowejPostaci++;

            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<MenuSavesController>().lista[i].GetComponent<IDPostaci>().ID ==
                ObjectReference.GetComponent<ObjectInListReferencePostac>().ID.ID)
            {
                MenuSavesController.idNowejPostaci = GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<MenuSavesController>().lista[i].GetComponent<IDPostaci>().ID;
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<MenuSavesController>().lista.RemoveAt(i);
                break;
            }
        }

        GameObject.FindGameObjectWithTag(Tagi.SpawnerPostacTag).GetComponent<SpawnerWyborPostaci>().Spawn();

    }

}
