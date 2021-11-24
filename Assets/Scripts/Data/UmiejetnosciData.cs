using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UmiejetnosciData : MonoBehaviour
{
    public bool akrobatyka = false;
    public bool atletyka = false;
    public bool historia = false;
    public bool intuicja = false;
    public bool medycyna = false;
    public bool opiekaNadZwierzetami = false;
    public bool oszustwo = false;
    public bool percepcja = false;
    public bool perswazja = false;
    public bool przyroda = false;
    public bool religia = false;
    public bool skradanieSie = false;
    public bool sztukaPrzetrwania = false;
    public bool sledztwo = false;
    public bool wiedzaTajemna = false;
    public bool wystepy = false;
    public bool zastraszanie = false;
    public bool zwinneDlonie = false;

    public void UpdateData(UmiejetnosciData ob)
    {
        akrobatyka = ob.akrobatyka;
        atletyka = ob.atletyka;
        historia = ob.historia;
        intuicja = ob.intuicja;
        medycyna = ob.medycyna;
        opiekaNadZwierzetami = ob.opiekaNadZwierzetami;
        oszustwo = ob.oszustwo;
        percepcja = ob.percepcja;
        perswazja = ob.perswazja;
        przyroda = ob.przyroda;
        religia = ob.religia;
        skradanieSie = ob.skradanieSie;
        sztukaPrzetrwania = ob.sztukaPrzetrwania;
        sledztwo = ob.sledztwo;
        wiedzaTajemna = ob.wiedzaTajemna;
        wystepy = ob.wystepy;
        zastraszanie = ob.zastraszanie;
        zwinneDlonie = ob.zwinneDlonie;

    }

}
