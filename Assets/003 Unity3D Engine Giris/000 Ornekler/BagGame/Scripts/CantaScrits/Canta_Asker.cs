using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Canta_Asker : Canta
{
    public bool KamufileEdilebilir { get; set; }
    public Canta_Asker(string _turu, int _kapasite, float _dayaniklilik, bool _matTakilabilir, SpriteRenderer _cantaSprite, bool _kamufileEdilebilir)
    {
        Turu = _turu;
        Kapasite = _kapasite;
        Dayaniklilik = _dayaniklilik;
        MatTakilabilir = _matTakilabilir;
        CantaSprite = _cantaSprite;
        KamufileEdilebilir = _kamufileEdilebilir;
        
    }
    public void AskerCantaOlustur()
    {

    }

}
