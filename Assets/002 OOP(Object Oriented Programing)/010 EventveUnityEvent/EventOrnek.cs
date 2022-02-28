using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOrnek : MonoBehaviour
{
    /*
    Eventler(Olaylar)

    Eventler tetiklenen olaylardir ve delegatelerden turerler. Delegatelerin bir tik otesi eventlerdir. Ornegin onClick be textChange bir eventtir.
    Delegateleri konu olarak islememizin bir nedenide event yapisini ogrenmektir.

    Event Nasil Yazilir?

    1)Event yazilmasi icin once delegatesi yazilmasi gereklidir.
    2)Yani o event icine alicagi methodun ne tur bi method oldugunu bilmesi gerekir.
    3)Delegate referansini methoddan alir.
    3,5)Event referansini delegateden alir.
    4)Eventlerde tetikleyici ve tetiklenenin ne oldugunu bulmamiz gerekir.

    Mouse hareketleride bir eventtir.
    */

    //public delegate void ODelegate();   //1 ilk once  delegate olusturulur.
    //public event ODelegate _OEvent;     //2-3 sonra olustururlan delegateden event yaratilir.


    public event Action _OEvent;
    // Geriye deger dondurmeyen ve parametre almayan bir eventtir.

    public event Action<int, int> _OEvent2;
    // Geriye deger dondurmeyen ve 2 parametre(int,int) alan bir eventtir.

    public event Func<string> _OEvent3;
    // Geriye string degerini donduren ve parametre almayan bir eventtir.

    public event Func<string, int, bool> _OEvent4;
    // Geriye bool degerini donduren ve 2 parametre(string,int) alan bir eventtir.
    // En sagdaki deger geri donus degeridir.



    private void OnEnable()
    {
        //Obje hirearside aktif oldugunda tetiklenir.

        _OEvent?.Invoke(); //null degilse ???????????
                           //if (_OEvent !=null)
                           //{
                           //    _OEvent.Invoke();
                           //}

        //Debug.Log("Obje aktif");
    }
    private void OnDisable()
    {
        //Obje hirearside pasif oldugunda tetiklenir.
        _OEvent?.Invoke();
        //Debug.Log("Obje pasif");

    }
    // Hirearside obje aktif mi pasif mi ona gore methodu calistirir. Kullanildigi obje icin gecerlidir.





}
