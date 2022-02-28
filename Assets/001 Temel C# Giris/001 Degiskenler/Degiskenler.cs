using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degiskenler : MonoBehaviour
{
    //Global degiskenler yazilir.(Class icersine)
    //Local degiskenler yazilir.(Method icersine)
    //(Awake)Starttan once ve bir defa calisir. Her zaman(inspectorde kapali olsa bile) calisir.   (Unity islevsel Method)
    //(Start)Awakeden sonra ve bir defa calisir. Start metodunun calismasi icin, script inspectorde aktif olmasi gerekir.
    //(Update)Bilgisayarin hizina gore bir saniyede 5 kerede calisabilir 100 kerede calisabilir.
    //(FixedUpdate)Her bilgisayarda saniyede ayni sayida calisir. Genellikle oyun fizik bolumlerinde kullanilir.
    ////Fizik olalarinda normal update kullanilmasi saglikli degildir. (Nedeni belirli araliklarla calismadigi icin orn.. topun dusmesi)
    ////Her 0.02(degisebilir) saniyede bir cagrilir.
    //(LateUpdate)En son calisan update fonksiyonudur. Tum islemler bittikten sonra calisir genel olarak kamera cevre yuklemesi(fixedupdate) bittikten sonra calisir.

    int a = 3;
    string araba = "mersedes";
    //float b = 10.5f;
    //string metin = "sinif";
    //bool dogru = true;

    string ad = "Yusuf";
    string soyAd = "Sener";
    int yas = 24;

    void Start()
    {

        Debug.Log(a + " benim arabam " + araba);                //beyaz uyari amblemi
        Debug.LogWarning(a + $" benim arabaa +{araba}");      //sari uyari amblemi
        Debug.LogError(a + araba);                            //kirmizi uyari amblemi
        Interpolition();
    }

    //void Update()     { }
    //void Awake()      { }
    //void FixedUpdate(){ }
    //void LateUpdate() { }

    void Interpolition()
    {
        //(Interpolition)"" icine yazdigimiz metnin icerisine {}(scope) araciligi ile deger cekmemizi saglar.
        Debug.Log($"benim arabam {araba}");
        Debug.Log($"Adim {ad}, Soyadim {soyAd}, Yasim {yas}");
    }

    /*
    Degisken isimleri benzersiz olmalidir.
    Degiskenler buyuk-kucuk harf duyarlidir.
    Degiskenler sayi ile baslayamaz.
    Degiskenler belirtilirken CamelCase yontemi kullanilir. Ornek : aracSayisi, yeniBirScripts, olmazOlsunText
    Degiskeni deklare ettikten sonra ";" kullanilir.
    */
}
