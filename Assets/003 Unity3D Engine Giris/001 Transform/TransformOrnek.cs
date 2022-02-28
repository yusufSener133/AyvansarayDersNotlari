using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformOrnek : MonoBehaviour
{
    /*
        Transform:  Transform komponenti Unity hierarchy sinde ekledigimiz her objede olmak zorundadir. Transformsuz bir gameObject dusunulemez. 
        Transformlar Unity evreninde; objenin, pozisyonunu, hangi yone baktigini ve boyutunu belirtmek icin kullanilir.

        Transform.position : XYZ koordinatlari konumu
        Transform.rotation : XYZ eksenleri etrafindaki donusu(derece cinsinden olculur)
        Transform.scale    : XYZ eksenleri boyunca objelerin olcegi(default degeri-orjinal boyutu "1" dir.)
    */
    private void Start()
    {
        //Genel Kullanimi
        transform.position += new Vector3(0, 0);
        transform.rotation = new Quaternion(90, 45, 0, 0);
        transform.localScale += new Vector3(0, 0, 0);
        //transform.Translate
    }



}
