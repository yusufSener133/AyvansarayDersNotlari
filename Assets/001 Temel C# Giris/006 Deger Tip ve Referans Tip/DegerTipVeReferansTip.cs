using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegerTipVeReferansTip : MonoBehaviour
{
    #region RAM

    /*              RAM
    _________________________________________
    |               |                       |
    |    stack      |       heap            |
    |               |                       |
    iiiiiiiiiiiiiiii iiiiiiiiiiiiiiiiiiiiiiii
    int             int[]
    string
    float

    */
    #endregion

    void ReferansTipler()
    {
        // Referans Tipler
        //Ram in heap kisminda tutulur.

        //String tipinde bir value1 adinda bir dizi olusturduk.
        //Bu dizinin ram kaynak adresi Ram201 olsun.
        //Ram201 Kaynak Adresi = values1
        string[] values1 = { "Istanbul", "Izmir", "Ankara" };

        //String tipinde bir value2 adinda bir dizi olusturduk.
        //Bu dizinin ram kaynak adresi Ram202 olsun.
        //Ram202 Kaynak Adresi = values2
        string[] values2 = { "Adana", "Diyarbakir", "Bursa" };

        values2 = values1;
        values1[0] = "Bodrum";

        Debug.Log(values1[0] + " + " + values2[0]);
        //cikti ---> Bodrum + Bodrum
        //                  --values2 referans kaynak degeri degisti. Ram202 iken Ram201 oldu. Dolayisiyla values1 deki degisim values2 yide etkiledi.
        Debug.Log(values1[1] + " + " + values2[1]);
        //cikti ---> Izmir + Izmir
        Debug.Log(values1[2] + " + " + values2[2]);
        //cikti ---> Ankara + Ankara
        foreach (var item in values2)
        {
            Debug.Log(item);
        }
        //cikti ---> Bodrum
        //cikti ---> Izmir
        //cikti ---> Ankara

    }

    void DegerTipler()
    {
        // Deger Tipler
        //Ram in steak alaninda tutrulur.

        //Integer tipinde bir sayi1 adinda bir degisken olusturduk.
        //Bu dizinin ram kaynak kodu Ram101 olsun.
        //Ram101 Kaynak kodu = sayi1
        int sayi1 = 10;
        //Integer tipinde bir sayi2 adinda bir degisken olusturduk.
        //Bu dizinin ram kaynak kodu Ram102 olsun.
        //Ram102 Kaynak kodu = sayi2
        int sayi2 = sayi1;
        sayi1++;

        Debug.Log("sayi1 ...> " + sayi1 + "\nsayi2...> " + sayi2);

    }



}
