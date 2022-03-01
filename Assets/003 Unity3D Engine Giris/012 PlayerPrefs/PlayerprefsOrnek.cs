using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerprefsOrnek : MonoBehaviour
{
    /*
     
    PlayerPrefs Nedir :

    Basit duzeyde veri depolamamizi kaydetmemizi saglayan yapidir. PlayerPrefs le oyuncunun yuksek skorunu altin sayisini ya da basit duzeyde uygulama dil seceneklerini tutmak icin kullanilir
    Ozetle PlayerPrefs le sahneler arasi veri tasiyabiliriz.

    PlayerPrefs ile int float ve string degerleri tutabilir ve duzenleyebiliriz.

    PlayerPrefs ile kullanilabilecek fonksiyonlar soyledir :

    Deleteall : Kayitli tum anahtar ve verileri siler.
    Deletekey : Belirtilen anahtar ve onunla ilgili her seyi siler.
    GetFloat  : Belirtilen anahtar ile degisken tipindeki veriye dondurur.
    GetString : Belirtilen anahtar ile degisken tipindeki veriye dondurur
    GetInt    : Belirtilen anahtar ile degisken tipindeki veriye dondurur
    SetFloat  : Degisken turu ile beraber belirtilen veriyi saklar.


     */

    [SerializeField] int _arttir;
    [SerializeField] Text _sayiText;
    [SerializeField] Text[] _buttonText;

    string _degerKaydedildi;
    private void Start()
    {
        SayiyiCagir();
        DilGetir();
    }

    private void DilGetir()
    {

        int _dil = PlayerPrefs.GetInt("dil");
        switch (_dil)
        {
            case 0:
                _buttonText[0].text = "Sayi Azalt";
                _buttonText[1].text = "Sayi Arttir";
                _buttonText[2].text = "Sifirla";
                _buttonText[3].text = "Kaydet";
                _degerKaydedildi = "(sayiyi kaydettik.)";
                break;
            case 1:
                _buttonText[0].text = "Number Down";
                _buttonText[1].text = "Number Up";
                _buttonText[2].text = "Reset";
                _buttonText[3].text = "Save";
                _degerKaydedildi = "(save number.)";
                break;
        }
    }

    private void SayiyiCagir()
    {
        _arttir = PlayerPrefs.GetInt("_kaydedilenSayi");
        _sayiText.text = _arttir.ToString();

    }

    public void SayiyiArttir()
    {
        _arttir++;
        _sayiText.text = _arttir.ToString();
    }
    public void SayiyiAzalt()
    {
        if (_arttir > 0)
        {
            _arttir--;
            _sayiText.text = _arttir.ToString();
        }

    }
    public void SayiyiSifirla()
    {
        _arttir = 0;
        _sayiText.text = _arttir.ToString();
    }
    public void SayiyiKaydet()
    {
        PlayerPrefs.SetInt("_kaydedilenSayi", _arttir);
        _sayiText.text = $"{_arttir} {_degerKaydedildi}";       
    }

    public void TurkceDil()
    {
        PlayerPrefs.SetInt("dil", 0);
        DilGetir();
    }
    public void IngilizceDil()
    {
        PlayerPrefs.SetInt("dil", 1);
        DilGetir();
    }
}
