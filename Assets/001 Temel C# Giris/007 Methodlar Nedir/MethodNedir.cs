using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodNedir : MonoBehaviour
{
    //void, method oldugunu ve parametre almayan(geriye bir deger dondurmeyen) anlamina gelir.
    //
    //***start methodu altinda ne kadar az method gorursek okadar iyi.

    [SerializeField] int kalkan;
    [SerializeField] int can;
    [SerializeField] int mermi;
    [SerializeField] int para;
    [SerializeField] string username;
    [SerializeField] string silah;
    [SerializeField] string takim;
    [SerializeField] bool banliMi;
    void Start()
    {
        OyunuBaslat();
    }
    void OyunuBaslat()
    {
        Oyuncu1();
        Oyuncu2();
        Oyuncu3();
        Oyuncu4();
        Oyuncu5();
    }
    void Oyuncu1()
    {
        username = "Baran";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu2()
    {
        username = "Ali";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu3()
    {
        username = "Veli";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu4()
    {
        username = "Japon";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void Oyuncu5()
    {
        username = "Semra";
        OyuncuBaslangicDegerleriniOlustur();
    }
    void OyuncuBaslangicDegerleriniOlustur()
    {
        silah = "M4A1";
        takim = "A";
        mermi = 404;
        can = 100;
        kalkan = 50;
        para = 0;
        banliMi = false;
        Debug.Log($"Isim = {username}\nSilah = {silah}\nMermi = {mermi}\nTakim = {takim}\nCan = {can}\nKalkan = {kalkan}\nPara = {para}\nBanli mi = {banliMi}");
    }
}
