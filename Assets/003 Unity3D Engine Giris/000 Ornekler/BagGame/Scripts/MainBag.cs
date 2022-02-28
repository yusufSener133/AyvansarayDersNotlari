using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBag : MonoBehaviour
{
    [SerializeField] SpriteRenderer _cantaSprite;
    [SerializeField] Text _turuText, kapasiteText, _dayaniklilikText, _matTakilabilirText, _kamufileEdilebilirText; 

    private void Update()
    {
        
    }
    void AskerCantasiniGoruntule()
    {

        Canta_Asker _cantaAsker = new Canta_Asker("Askeri Canta", 100, 92.5f, true, _cantaSprite, true);
        Debug.Log(_cantaAsker);
        _turuText.text = _cantaAsker.Turu;
    }
}
