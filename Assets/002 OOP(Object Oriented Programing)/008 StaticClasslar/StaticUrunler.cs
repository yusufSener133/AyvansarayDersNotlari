using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticUrunler
{
    /*
    // Static classlar iclerine normal yapilar alamazlar.
    //int normalField; ----> Hata verir
    static int staticField;

    //public int normalProp { get; set; }  ----> Hata verir
    public static int staticProp { get; set; }

    //void normalMethod()  ----> Hata verir
    //{
    //}
    static void staticMethod()
    {

    }
    */

    public static int ID { get; set; }
    public static string ItemAdi { get; set; }
    public static decimal ItemFiyati { get; set; }


    public static string EkranaYazdir()
    {
        return $"ID = {ID}\nUrunun Adi = {ItemAdi}\nUrunun Fiyati = {ItemFiyati:C2}";
        //C2 para formatidir. TLdir.
    }

}
