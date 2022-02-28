using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacSingleton : MonoBehaviour  //MonoBehaviour icin singleton patternidir.
{
    //Bu yontem MonoBehaviour dan miras alan classlar icin gecerlidir.

    public static AgacSingleton Instance { get; private set; }

    void Awake()
    {
        //Awake icerisinde bir kere referans almasini istedigimiz icin private kullandik. Yani Disaridan alamaz, bir kere agac referansini alabiliriz.
        if (Instance == null) //Instance icerisinde referans yoksa yani null(referans var mi yok mu) ise...
        {
            Instance = this; //this(Kendisi.Kim ? Bu class, yani diyoruzki bu classin referansini bu Instance degiskenine ata.)
            DontDestroyOnLoad(this.gameObject); // Yeni bir sahne yuklenirken hedef nesneyi yok etmeyin.
        }
        else
        {
            Destroy(this.gameObject); //Destroy(yoket.Kim ? kendisini)
        }
    }





}