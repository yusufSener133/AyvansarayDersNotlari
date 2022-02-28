using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    
    void Start()
    {
        BMW BMW1 = new BMW("BMW", "X5");
        //BMW1.Marka = "BMW";
        //BMW1.Model = "X5";
        BMW1.SifirMi = true;
        BMW1.UcuyorMu = true;
        BMW1.Hizi = 320f;
        BMW1.KapiSayisi = 4;
        BMW1.Fiyati = 150000;

        BMW1.SatisYap();

        string aracFiyatiBMW = BMW1.ToplamFiyati.ToString();
        
        Mersedes mersedes = new Mersedes();
        mersedes.Marka = "mersedes";
        mersedes.Model = "M5";
        mersedes.SifirMi = true;
        mersedes.YuzuyorMu = true;
        mersedes.Hizi = 380f;
        mersedes.KapiSayisi = 2;
        mersedes.Fiyati = 380000;

        mersedes.SatisYap();

        string aracFiyatiMersedes = mersedes.ToplamFiyati.ToString();

        

    }



}
