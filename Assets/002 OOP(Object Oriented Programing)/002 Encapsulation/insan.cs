using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insan  //base class
{
    //Base class olustur denirse hicbir yerden miras almayan bir script
    //// : MonoBehaviour u sileceksiniz.
    ////icindekileri temizleyeceksiniz.

    //string firstName, lastName;
    //int age;
    //decimal money;



    //property : tasiyicilar
    //prop tab tab

    //new property
    // new property de encapsulation kullanamam. old property kullanicaz.
    // Kapsulleme ismemi new prop icinde yapilamaz.
    // ***
    // Bir kapsulleme islemi yapmak istiyor isek islem yapilacak olan prop old prop a donusmek zorundadir.
    // ***
    //// property public olabilir ama sikinti yok.
    ////get getiren set gonderen

    //public int FirstName { get; set; }
    public string FirstName
    {
        get { return FirstName; }
        set
        {
            if (FirstName.Length > 6)
            {
                Debug.Log("Isminiz uzun");
            }
            else
            {
                FirstName = value;
            }
        }
    }
    public string LastName { get; set; }
    //public int Age { get; set; }
    public int Age
    {
        get { return Age; }

        set
        {
            if (value < 0 || value > 100)
            {
                Debug.Log("Hatali giris");
                Age = 18;

            }
            else
            {
                Debug.Log("Giris Basarili");
                Age = value;
            }
        }
    }
    public decimal Money { get; private set; }
    //                         sadece base class icinden erisilebilir.

    public string LastName2
    {

        get
        {
            return LastName2;
        }

        set
        {
            LastName2 = value;
        }

    }



}
