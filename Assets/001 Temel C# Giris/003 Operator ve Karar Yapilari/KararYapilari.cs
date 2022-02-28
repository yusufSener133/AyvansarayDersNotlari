using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KararYapilari : MonoBehaviour
{
    int sayi = 10;
    string ay;
    void IfElse()
    {
        if (sayi == 10)
        {
            Debug.Log($"{sayi} 10 dur.");

        }
        else if (sayi < 10)
        {
            Debug.Log($"{sayi} 10 dan kucuktur.");
        }
        else
        {
            Debug.Log($"{sayi} 10 dan buyuktur.");
        }

        //---Ternary If ---
        // tek satirda if
        Debug.Log(sayi == 10 ? "sayi 10" : "sayi 10 degil");
    }

    void SwitchCase()
    {
        switch (ay)
        {
            case "Ocak":
                Debug.Log($"{ay} ayindayiz");
                break;
            case "Subat":
                Debug.Log($"{ay} ayindayiz");
                break;

        }
    }
}
