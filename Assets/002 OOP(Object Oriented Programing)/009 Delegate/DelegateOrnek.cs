using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOrnek : MonoBehaviour
{
    /*
    Delegate(Temsilci)

    Program icersinde bir veya daha fazla methodu gosteren referans turunden bir nesnedir.

    Programlarimizda temisilciler kullanmak istedigimizde oncelikle bu temsilcinin tanimini yapmaliyiz.
    Temsilci tanimlari, method tanimlari gibidir.
    Tek fark delegate anahtar sozcugunu kullaniriz.

    */

    public delegate void DelegateOrnek1();                       // Bu methodumuz geriye deger dondurmeyen ve parametre almayan bir delegatedir.
    public delegate void DelegateOrnek2(int sayi1, int sayi2);   // Bu methodumuz geriye deger dondurmeyen ve iki* parametre alan bir delegatedir.
    public delegate void DelegateOrnek3(int sayi1, string metin1, bool tahmin1, bool tahmin2);  //geriye deger dondurmeyen ve dort* parametre alan bir delegatedir.




    void Start()
    {

        DelegateOrnek1 _do1 = new DelegateOrnek1(ParametreAlmayanOrnek1);
        DelegateOrnek2 _do2 = new DelegateOrnek2(IkiParametreAlanOrnek1);
        _do2 += IkiParametreAlanOrnek2; //do2 ye methodu ekledi. Yani iki methodu tutuyor.
        _do2 += IkiParametreAlanOrnek3; //do2 ye methodu ekledi. Yani uc methodu tutuyor.
        _do2(4, 4);
        _do2.Invoke(5, 5);
        Ornek();

    }



    void ParametreAlmayanOrnek1()
    {

    }
    void IkiParametreAlanOrnek1(int sayi1, int sayi2)
    {
        Debug.Log($"Toplami = {sayi1 + sayi2}");
    }
    void IkiParametreAlanOrnek2(int sayi1, int sayi2)
    {
        Debug.Log($"Farki = {sayi1 - sayi2}");
    }
    void IkiParametreAlanOrnek3(int sayi1, int sayi2)
    {
        Debug.Log($"Carpimi = {sayi1 * sayi2}");

    }

    public delegate void Islem(int sayi1, int sayi2, string sonuc, bool olurMu);
    void Ornek()
    {
        Islem _islem = new Islem(Topla);
        _islem += Cikar;
        _islem += Carp;
        _islem(10, 5, "", true);
    }
    void Topla(int sayi1, int sayi2, string sonuc, bool olurMu)
    {
        sonuc = "Toplami = ";
        int sonuc1 = (sayi1 + sayi2);
        Debug.Log(sonuc + sonuc1);
    }
    void Cikar(int sayi1, int sayi2, string sonuc, bool olurMu)
    {
        sonuc = "Farki = ";
        int sonuc1 = (sayi1 - sayi2);
        Debug.Log(sonuc + sonuc1);
    }
    void Carp(int sayi1, int sayi2, string sonuc, bool olurMu)
    {
        sonuc = "Carpimi = ";
        int sonuc1 = sayi1 * sayi2;
        Debug.Log(sonuc + sonuc1);
    }














}
