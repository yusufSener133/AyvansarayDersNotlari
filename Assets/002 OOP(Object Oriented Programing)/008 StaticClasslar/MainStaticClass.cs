using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStaticClass : MonoBehaviour
{
    /*
    Static olan bir class ya da yapi(fieldler,methodlar vs.) tekildir. Ypi 1 kere olusturlar ve program calisincaya kadar omurlerini devam ettirirler.
    Bizler genelde static classlardan kaciniriz. Bunun nedeni ise bir static class oldugunda her sey static olmalidir.
    Static classlar sadece static uyeler icerir. Mutlaka uyelerin basina statik keywordu eklenmelidi.
    Static classlar baska bir siniftan inheritance alamazlar. Bu classlardan staticte olsa baska classlar uretilemez.
    newlenmez.
    --static classlar belirlenirken static yapidaki scritlere s eklenebilir (Urunler,UrunlerS-Urunlers)


    */

    private void Start()
    {

        /*-----Diger yol-----
        * Urunler _urunler1 = new Urunler()
        * Urunler.ID = 1;
        * Urunler.ItemAdi = "Item1";
        * Urunler.ItemFiyati = 445M;
        */
        Urunler _urunler1 = new Urunler() { ID = 1, ItemAdi = "Item1", ItemFiyati = 445M };
        Urunler _urunler2 = new Urunler() { ID = 2, ItemAdi = "Item2", ItemFiyati = 445M };
        Urunler _urunler3 = new Urunler() { ID = 3, ItemAdi = "Item3", ItemFiyati = 445M };

        StaticUrunler.ID = 11;
        StaticUrunler.ItemAdi = "Item11";
        StaticUrunler.ItemFiyati = 440M;

        List<string> urunListesi = new List<string>()
        {
            _urunler1.ToString(),
            _urunler2.ToString(),
            _urunler3.ToString(),
            StaticUrunler.EkranaYazdir(),
            StaticUrunler.EkranaYazdir(),
            StaticUrunler.EkranaYazdir()
        };
        foreach (var item in urunListesi)
        {
            Debug.Log(item);
        }



        //Debug.Log(StaticUrunler.EkranaYazdir());
        //Debug.Log(ToString());



    }


}

