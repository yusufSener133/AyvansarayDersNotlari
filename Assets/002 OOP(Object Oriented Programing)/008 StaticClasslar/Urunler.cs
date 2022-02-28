using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Urunler
{
    /*
    // Normal classlar iclerine static yapilar alabilirler.
    int normalField;
    static int staticField;

    public int normalProp { get; set; }
    public static int staticProp { get; set; }

    void normalMethod()
    {

    }
    static void staticMethod()
    {

    }
    */

    public int ID { get; set; }
    public string ItemAdi { get; set; }
    public decimal ItemFiyati { get; set; }

    public override string ToString()
    {
        return $"ID = {ID}\nUrunun Adi = {ItemAdi}\nUrunun Fiyati = {ItemFiyati:C2}";
    }

}
