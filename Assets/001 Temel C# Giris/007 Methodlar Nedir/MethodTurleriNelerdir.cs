using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodTurleriNelerdir : MonoBehaviour
{
    void Start()
    {
        Method1();
        Method2();
        Method3(1, 2);
        Method3(1, 2, 5);
        Method3(1, 2, 5, "a");

        Methodumuz(5);

        MethodKelime(new string[3]);
        MethodKelime2(5, 10, 11);
        int a = 11;
        int b;
        Method7(ref a, out b);
    }
    void Method1()
    {
        //Bu method parametre almayan ve deger dondurmeyen bir method'dur.
        //Method isimleri uniqe olmalidir. [parametresi DAHIL] (Eger parametre almiyosa)
    }

    private int Method2()
    {
        //Bu method parametre almayan ve geriye deger donduren bir method'dur.

        int a = 10;
        int b = 11;
        int sonuc = a + b;
        return sonuc;
    }
    void Method3(int a, int b)
    {
        int sonuc = a + b;
        Debug.Log(sonuc);
    }
    void Method3(int a, int b, int c)
    {
        int sonuc = a + b + c;
    }
    void Method3(int a, int b, int c, string d)
    {
    }

    void ProfilBilgileriGuncelleme(string username, int id, bool info, int plaka)
    {

    }


    void Methodumuz(int sayi1 = 10, int sayi2 = 10/*default parametre diyolla*/)
    {
        int sonuc = sayi1 + sayi2;
        Debug.Log(sonuc);
    }


    void MethodKelime(string[] kelime)
    {
        kelime[0] = "mihrap";
        kelime[1] = "kayra";
        kelime[2] = "baran";
        foreach (var item in kelime)
        {
            Debug.Log(item);
        }
    }
    void MethodKelime2(params int[] kelime)
    {

        foreach (var item in kelime)
        {
            Debug.Log(item);
        }
    }

    /*
    //int[] sayi methodunun cagirmak icin Method5(new int[5]) yapmali ve        cikti --> 50 51 0 0 0
    //params int[] sayi yaparsak cagirdigimizda Method5(5,5,5,5) yaparsak       cikti --> 50 51 5 5
    //ne kadar deger alicagimizi bilmedigimiz zaman params kullanilir.
    //Params keyword u n kadar dizi elemani girilmesini saglar.
    void Method5(params int[] sayi)
    {
    sayi[0] = 50;
    sayi[1] = 51;
    int toplam = sayi.Sum;
    //sayi.Sum = sayi[0] + sayi[1];
    foreach (var item in sayi)
    {
    Debug.Log(item);
    Debug.Log(toplam.ToString());
    }
    }

    */


    void Method7(ref int sayi1, out int sayi2)
    {
        //ref deger tipi referans tipine donusturur.
        //ref ilk deger bekler.
        //out
        //out belirttigimiz method icinde deger bekler.
        sayi1 = 10;
        sayi2 = 11;
        Debug.Log($"sayi1 = {sayi1}, sayi2 = {sayi2}, toplam = {sayi1 + sayi2}");
    }










}

