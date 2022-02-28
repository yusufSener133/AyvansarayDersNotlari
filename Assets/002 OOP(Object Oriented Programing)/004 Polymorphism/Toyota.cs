using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toyota : Araba, IFransiz
{
    bool FransizMiKontrol;
    public bool FransizMi
    {
        get
        {
            return FransizMiKontrol;
        }
        set
        {
            FransizMiKontrol = value;
        }
    }

    public void FransizIndirimiYap()
    {

    }

    public void FransizMersedesIndirimiYap()
    {
    }
}
