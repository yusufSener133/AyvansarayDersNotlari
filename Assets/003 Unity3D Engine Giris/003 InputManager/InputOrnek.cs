using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputOrnek : MonoBehaviour
{
    /*
    Input sinifinin methodlariyla kullanicidan tum gildileri alabiliriz. Genellikle True False cevabi dondugu icin cogunlukla if bloklarinda kullanildigini goruruz.
    

     */
     void FixedUpdate()
    {
        //GetKey Methodu            : Kullanicinin klavye uzerinden, belirtilen tusa basilip basilmadigini tesbit etmek icin kullanilir. Basili tuttukca calisir.
        if (Input.GetKey("w"))
        {
            Debug.Log("w");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("s");
        }

        //GetKeyDown Methodu        : GetKey methodunda oldugu gibi kullanici kilavyeden tusa bastigi zaman sonuc doner. Sadece bir kez calisir.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
        }

        //GetKeyUp Methodu          : GetKeydown in tersi seklinde calisir. Belirtilen tusa basmayi birakinca calisir.
        if (Input.GetKeyUp("a"))
        {
            Debug.Log("a");
        }

        //GetMouseButton Methodu    : Mouse uzerinde yer alan tuslara basili tutulup tutulmadigini kontrol eder. (0)(1)(2)
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse sol tus");
        }if (Input.GetMouseButton(1))
        {
            Debug.Log("Mouse sag tus");
        }if (Input.GetMouseButton(2))
        {
            Debug.Log("Mouse orta tus");
        }

        //GetMouseButtonDown        : Bir kere calisir.
        //GetMouseButtonUp          : Tusu birakinca calisir.
        
        //Edit -> Project Settings -> Input Manager
        //GetAxis Methodu           : Unity oyun motorunun bazi standart yonlendirme islemleri icin varsayilan olarak gelen input manager yapisi bulunur. GetAxis methodu ile bu hazir yapilara erisebilir ya da kendi olusturdugumuz yapilari kullanabiliriz.
    }

    
}
