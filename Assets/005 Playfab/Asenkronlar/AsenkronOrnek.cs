using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsenkronOrnek : MonoBehaviour
{
    bool _wait;
   /*
    
    
    */
    IEnumerator Asenkron()
    {
        yield return new WaitUntil(() => _wait);
    }
}
