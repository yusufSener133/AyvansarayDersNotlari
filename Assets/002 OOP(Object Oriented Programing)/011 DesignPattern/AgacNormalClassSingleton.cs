using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacNormalClassSingleton //hatali xxxxxx
{
    private static AgacNormalClassSingleton _Instance; //classtan degisken olusturuk (aldigimiz variable)
    public AgacNormalClassSingleton()
    {

    }

    private void Awake()
    {
        AgacNormalClassSingleton _agac1 = AgacNormalClassSingleton.OktayInstance();
        AgacNormalClassSingleton _agac2 = AgacNormalClassSingleton.OktayInstance();
        AgacNormalClassSingleton _agac3 = AgacNormalClassSingleton.OktayInstance();
    }

    public static AgacNormalClassSingleton OktayInstance()
    {
        if (_Instance == null) //degisken bossa - referansi yoksa
        {
            _Instance = new AgacNormalClassSingleton(); //newledik - classin referansini _Instance ye attik.

        }
        return _Instance;
    }

}