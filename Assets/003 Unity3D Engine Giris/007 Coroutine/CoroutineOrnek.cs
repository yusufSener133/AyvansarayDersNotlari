using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineOrnek : MonoBehaviour
{
    [SerializeField] SpriteRenderer _circle1, _circle2, _circle3;
    [SerializeField] Text _text;
    /*
    Coroutine : Bu methodun en cok kullanim sekli projemizdeki bir kodu belli bir zaman sonra baslatmaktir. Coroutineler yazilan bir methodun bitmesini bekliyebilir ve daha sonra bekledigi method islemlerini bitirdikten sonra bir sonraki methoda gecer. Yani

    StartCoroutine(method1());

     */
    void Start()
    {
        StartCoroutine(TrafikLambasi());
    }
    void Kirmizi()
    {
        _circle1.color = Color.red;
        _circle1.transform.position += new Vector3(1, 0);
        _text.text = "DUR!";
        _text.color = Color.red;
    }
    void Sari()
    {
        _circle2.color = Color.yellow;
        _circle2.transform.position += new Vector3(1, 0);
        _text.text = "HAZIRLAN";
        _text.color = Color.yellow;
    }
    void Yesil()
    {
        _circle3.color = Color.green;
        _circle3.transform.position += new Vector3(1, 0);
        _text.text = "GEC";
        _text.color = Color.green;
    }
    IEnumerator TrafikLambasi() //icine deger almaya ve geriye deger donduren interfacedir.
    {
        _circle3.transform.position = new Vector3(0, _circle3.transform.position.y);
        _circle3.color = Color.white;
        yield return new WaitForSeconds(1); //Bir sey dodurmesini ve kirmizi methoduna donmesini saglar.
        Kirmizi();
        yield return new WaitForSeconds(1);
        _circle1.color = Color.white;
        _circle1.transform.position = new Vector3(0, _circle1.transform.position.y);
        Sari();
        yield return new WaitForSeconds(1);
        _circle2.color = Color.white;
        _circle2.transform.position = new Vector3(0, _circle2.transform.position.y);
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(TrafikLambasi());
        Yesil();

    }
}
