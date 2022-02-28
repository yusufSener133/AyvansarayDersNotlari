using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ornek1Main : MonoBehaviour
{
    List<Silah> _silahListesi = new List<Silah>();
    [SerializeField] InputField _itemAdi, _itemAdet;
    [SerializeField] Text a, b;


    void Start()
    {
        //Silah _silah1 = new Silah("Mizrak", 2);
        //_silahListesi.Add(_silah1);

        //Silah _silah2 = new Silah("yay", 1);
        //_silahListesi.Add(_silah2);

        //foreach (var item in _silahListesi)
        //{
        //    Debug.Log(item);
        //}
    }

    void Update()
    {

    }

    public void ListeEkle()
    {
        Silah _silah1 = new Silah(_itemAdi.text, System.Convert.ToInt32(_itemAdet.text));
        _silahListesi.Add(_silah1);

        foreach (var item in _silahListesi)
        {
            Debug.Log($"Ismi = {item.ItemAdi} Adeti = {item.ItemAdet}\n");

        }
    }



}
