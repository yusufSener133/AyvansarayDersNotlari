using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donguler : MonoBehaviour
{
    //while
    //do while
    //for
    //foreach

    void WhileOrnek()
    {
        int a = 0;
        while (a != 65)
        {
            Debug.Log("Calis While");
            a++;
        }
    }
    void ForOrnek()
    {
        for (int i = 0; i < 65; i++)
        {
            Debug.Log("Calis For");
            if (i == 2)
            {
                continue;   // i = 2 atlandi.
            }
            if (i > 50)
            {
                break;     // kir ve bitir.
            }
        }
    }

    void DoWhileOrnek()
    {
        int b = 10;
        do
        {
            Debug.Log("Illaki Calisican DoWhile");
        } while (b > 100);
        //while, sart saglandiginda icine bir daha girmez ve calismaz. Fakat "do" ile kullanildiginda en az bir kere calistir.
    }

}
