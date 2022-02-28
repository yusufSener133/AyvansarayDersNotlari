using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    [SerializeField] EventOrnek _eventOrnek;    //Unity uzerinde hierarchyden erisiyoruz.
                                                //EventOrnek _eventOrnek2;                    //FindObjectOfType ile dosyayi kendin bul diyoruz.
                                                //EventOrnek _eventOrnek3;                    //GetComponent ile scripti kendin bul diyoruz.




    void Start()
    {

    }

    void Awake()
    {//awakede yazmak onemlidir.
     //_eventOrnek2 = FindObjectOfType<EventOrnek>();  //Hierarchy taranir ve EventOrnek bulunarak referans alir.
     //_eventOrnek3 = GetComponent<EventOrnek>();      //scriptin atili oldugu mainde falna filan
    }
    void Update()
    {

    }

    private void OnEnable()
    {
        _eventOrnek._OEvent += _eventOrnek__OEvent; //Evente olayi ekleriz.
    }

    private void OnDisable()
    {
        _eventOrnek._OEvent -= _eventOrnek__OEvent; //Eventen olayi cikartiriz.
    }
    private void _eventOrnek__OEvent()
    {
        Debug.Log("Tetiklendi.");
    }
}
