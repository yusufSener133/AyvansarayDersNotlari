using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour

/*

Text based bir oyun yap .
Alttaki olabilecek cok kotu bir ornek


*/



{
    public Text _merhabaTxt, _hitapTxt, _placeHolderTxt, _resultTxt, _sonucTxt;
    public InputField _adInput;

    string tasiyiciAd;

    private void Awake()
    {
        _merhabaTxt.text = "Merhaba Yolcu";
        _hitapTxt.text = "Sen buralardan degilsin. Sen kimsin";
        _placeHolderTxt.text = "Bennn....";


    }

    public void IsmiKontrolEt()
    {
        if (_adInput.text.Length >= 11)
        {
            _resultTxt.text = "Abartma";
            _resultTxt.color = Color.red;
            _sonucTxt.text = "";

        }
        else if (_adInput.text.Length == 0 || _adInput.text.Length <= 3)
        {
            _resultTxt.text = "Az yazdin sanki";
            _resultTxt.color = Color.red;
            _sonucTxt.text = "";
            if (_adInput.text == "At")
            {
                _sonucTxt.text = "At mi Cidden mi";
            }
        }
        else
        {

            _resultTxt.text = "Bu olur gibi";
            _resultTxt.color = Color.green;
            tasiyiciAd = _adInput.text;
            Karsilama();
        }


    }

    void Karsilama()
    {
        _sonucTxt.text = $"Demek adin {tasiyiciAd}. Buna pek inanmadim.";
    }
}
