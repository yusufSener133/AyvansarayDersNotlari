using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba
{
    //abstract =  Sadece miras verebilir.      (public abstract class Araba) ----> En sonda
    //sealed   =  Miras veremezsin.            (public sealed class Araba)   ----> En sonda

    //Base classlar icersinde visual class hale getirebilirsen beni ezebilirsin.
    //Polymorphism virtual olmayan bir methodu sanallastirip override etmenizi saglar.
    /*
    methodu sanal yaparsak methodu miras alip kullanildigi zaman onu ezebiliriz "override" ile
    public virtual void     ... araba classinda yazilir.
    public override void    ... araba classini miras alinanlarda yazilir.


    */

    public string Marka { get; set; }
    public string Model { get; set; }
    public bool SifirMi { get; set; }
    public float Hizi { get; set; }
    public byte KapiSayisi { get; set; }
    public decimal Fiyati { get; set; }
    public decimal ToplamFiyati { get; protected set; }

    public virtual void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 2000m;
        }


    }


}
