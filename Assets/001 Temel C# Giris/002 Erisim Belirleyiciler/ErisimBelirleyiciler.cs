using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErisimBelirleyiciler : MonoBehaviour
{
    void Method1() { }
    private void Method2() { }
    //private: Gizli olan degerleri tanimlamak icin kullandigimiz erisim belirleyicisidir. Sadece kendi bulundugu "class" icerisinden erisilebilir. Eger yazdigimiz kodda degistirilmemesini istedigimiz alanlar var ise buralari private yapmak gereklidir.

    public void Method3() { }
    //public: Verilen degerlere siniflardan da erisilmesini ve duzenlenebilmesini saglar.

    protected void Method4() { }
    //protected: Verilen degeri korumali hale getirir. Sadece ayni siniftan tureyen siniflar tarafindan kullanilabilir.

    internal void Method5() { }
    //internal: Ayni program(solution) icerisinden erisilebilir. Farkli bir program icerisinden erisilemez.

    /*Unity Erisim Belirleyicileri*/
    [SerializeField] private int _sayi1;
    //private olmasina ragmen unityde gorunuyor. public olsun yada olmasin, tum degerlerin inspectorda gozukmesini saglar.
    [HideInInspector] public int sayi2 = 0;
    //public olmasina ragmen unityde gozukmuyor. public girilen degerlerin, inspectorde gizlenmesini saglar
}
