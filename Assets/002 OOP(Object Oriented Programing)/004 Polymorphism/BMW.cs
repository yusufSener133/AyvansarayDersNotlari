using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMW : Araba, IAlman
{
    //Yalniz bir miras alir ama istedigi kadar interface alabilir.

    //protected bir tek aldigi class ve miras aldigi class icersinden degeri alir.
    //----------------------------class BMW kendi voidini olusturuyor.
    //BMW class oldugu icin method ozelliklerini de tasiyor.        |
    //Araba dan miras aldigimizda new lemis oluyoruz.               |
    //Yani BMW _BMW = new BMW(); gerek yok.                         |
    //                                                              |
    /*                                                              |
    * public BMW() **void yok   <<<-------------------------------<
    Bu method bu alanda gozukmese bile arka planda vardir. Bu bir yapici methoddur. Yapici methodlar birden fazla yuklenme(overload) alabilir.

    */

    public bool UcuyorMu { get; set; }


    public bool AlmanMi { get; set; }
    public void AlmanIndirimiYap()
    {
        if (AlmanMi)
        {
            ToplamFiyati -= 5000;
        }
    }
    public void AlmanMersedesIndirimiYap()
    {

    }


    public override void SatisYap() // ezdik
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 8000m;
        }

        if (UcuyorMu)
        {
            ToplamFiyati += 12000m;
        }
    }




    //*********o**n**e**m**l**i*****************
    // ctor tabtab
    public BMW(string _Marka, string _Model)
    {
        Marka = _Marka;
        Model = _Model;
    }

    public BMW(string _Marka, string _Model, bool _SifirMi, float _Hizi, byte _KapiSayisi, decimal _Fiyati)
    {
        Marka = _Marka;
        Model = _Model;
        SifirMi = _SifirMi;
        Hizi = _Hizi;
        KapiSayisi = _KapiSayisi;
        Fiyati = _Fiyati;
    }

    public BMW(string _Marka, string _Model, bool _SifirMi, float _Hizi, byte _KapiSayisi, decimal _Fiyati, bool _UcuyorMu)
    {
        Marka = _Marka;
        Model = _Model;
        SifirMi = _SifirMi;
        Hizi = _Hizi;
        KapiSayisi = _KapiSayisi;
        Fiyati = _Fiyati;
        UcuyorMu = _UcuyorMu;
    }


}




