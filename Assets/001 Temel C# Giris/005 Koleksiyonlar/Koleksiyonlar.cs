using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koleksiyonlar : MonoBehaviour
{
    int[] a = new int[10];              //***********************************************
    int[] b = { 1, 2, 3, 4, 5 };        //***********************************************
    int[] a1 = new int[3] { 1, 3, 5 };  //***********************************************
    int c = 10;

    [SerializeField] int[] ornekDizi;
    //inspectorda arrayi gorebiliyorum


    /*  Dizi                        int[] a = new int[10];
    List                        List<int> a = new List<int>();
    Dictionary                  Dictionary<int, string> a = new Dictionary<int, string>();
    Quene                       Queue<string> a = new Queue<string>();


    Dizilerin .Length vardir listelerin .Count vardir ---boyu---eleman sayisi---

    Bir dictionary icersinde "key"ler benzersiz olmasidir.

    Queue koleksiyon yapisinda ilk giren ilk cikar.
    EnQueue => Ekler
    DeQueue => Cikarir
    */
    void ArrayOrnek()
    {
        for (int i = 0; i < 10; i++)
        {
            a[i] = c * i + 1;
        }
    }
    void ListOrnek()
    {
        List<string> listeOrnek = new List<string>();
        listeOrnek.Add("kirmizu");
        listeOrnek.Add("sarii");
        listeOrnek.Add("basketboll");
        listeOrnek.Add("futbol");
        listeOrnek.Add("hentbol");

        List<int> sayi = new List<int> { 01, 02, 03, 04, 05 };

        for (int i = 0; i < listeOrnek.Count; i++)
        {
            Debug.Log(listeOrnek[i]);
        }
    }
    void DictionaryOrnek()
    {
        Dictionary<int, string> dictonaryOrnek = new Dictionary<int, string>();
        dictonaryOrnek.Add(1, "kalem");
        dictonaryOrnek.Add(2, "kalem");

        foreach (var item in dictonaryOrnek)
        {
            Debug.Log(item);
        }

    }
    void QueueOrnek()
    {
        Queue<string> gunler = new Queue<string>();
        gunler.Enqueue("Pazartesi");
        gunler.Enqueue("Sali");
        gunler.Enqueue("Carsamba");
        gunler.Enqueue("Persembe");
        gunler.Enqueue("Cuma");

        for (int i = 0; i < gunler.Count; i++)
        {
            Debug.Log(gunler.Dequeue() + "-----");
        }

        foreach (var item in gunler)
        {
            Debug.Log(item);
        }
    }
}
