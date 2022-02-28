using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractNedir : MonoBehaviour
{
    /*
    ____________________________________
    --------Abstract (Soyutlama)--------

    Soyut ve somut base classlar vardir.
    Ornegin; Araba, BMW, Toyota, Mersedes classlari base classlardir.
    Bu siniflar araba sinifindan miras almislardir ve somut bir base class olduklari icin "new" lenebilirler.

    Araba classi ice hepsinin ortak noktasidir ve soyut olmasi gerekir.
    Olusturulan base classlar icerisinde ortak bir nokta var ise o ortak alanlardan base class olusturulur ve soyutlama islemi yapilir.

    public abstract class ClassAdi() { }    // abstract eklenir.
    Yukaridaki method su anlama gelir :
    abstract eklenerek araba classi soyutlastirildi ve baska bir yerde ornegi alinamaz(new lenemez) durumuna getirildi.

    Abstract in genel olarak tek bir gorevi vardir :
    diger classlara miras vermek. Bu amac disinda kullanilamaz.
    Abstract yapilan classlar icerisinde bulunan methodlara miras alinmayan siniflardan ulasilamaz. (Virtual disinda)

    Peki neden abstract yaptik :
    solid prensiplerinin ilk harfi "S" :Single Responsibility Principle(SRP)
    Ozet : Bir sinif (nesne / class) yalnizca bir amac ugruna degistirilebilir, oda o sinifa yuklenen sorumluluktur.
    Yani bir sinifin yapmasi gereken sadece BIR IS OLMALIDIR.   (methodlara indirgenebilir.(her methodun bir isi olmalidir.))

    */

    /*
    __________________________________
    --------Sealed(Muhurleme)--------

    Muhurleme anlamina gelir ve bu class hicbir classa miras veremez.

    public sealed class ClassAdi() { }    // sealed eklenir.

    */

    /*
    Abstract method ile Virtual methot arasindaki fark:
    abstract methodlar ezilmek zorundadir. Her kullanildigi yerde yeniden yazilmalidir.
    virtual methodlar keyfi ezilebilir. Yani kullanildigi zaman base dekide kullanilabilir.
    */
}
