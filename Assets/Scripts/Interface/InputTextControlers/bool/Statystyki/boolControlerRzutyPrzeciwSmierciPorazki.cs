using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolControlerRzutyPrzeciwSmierciPorazki : MonoBehaviour
{
    [SerializeField] ZmianaKoloruPic _image1;
    [SerializeField] ZmianaKoloruPic _image2;
    [SerializeField] ZmianaKoloruPic _image3;

    public void PobierzBool()
    {
        int iloscTrue = 0;
        foreach (var item in GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki)
        {
            if (item == true) iloscTrue++;
        }

        if (iloscTrue == 0)
        {
            _image1.ZmienNaBialy();
            _image2.ZmienNaBialy();
            _image3.ZmienNaBialy();
        }

        if (iloscTrue == 1)
        {
            _image1.ZmienNaCzarny();
            _image2.ZmienNaBialy();
            _image3.ZmienNaBialy();
        }

        if (iloscTrue == 2)
        {
            _image1.ZmienNaCzarny();
            _image2.ZmienNaCzarny();
            _image3.ZmienNaBialy();
        }

        if (iloscTrue == 3)
        {
            _image1.ZmienNaCzarny();
            _image2.ZmienNaCzarny();
            _image3.ZmienNaCzarny();
        }
    }

    public void ZmienBoolnaPrawde()
    {
        for (int i = 0; i < GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki.Length; i++)
        {
            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki[i] == false)
            {
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki[i] = true;
                break;
            }

        }
    }

    public void ZmienBoolnaFalsz()
    {
        for (int i = 0; i < GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki.Length; i++)
        {
            if (GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki[i] == true)
            {
                GameObject.FindGameObjectWithTag(Tagi.DataTag).GetComponent<RzutyPrzeciwSmierci>().Porazki[i] = false;
                break;
            }

        }
    }

}
