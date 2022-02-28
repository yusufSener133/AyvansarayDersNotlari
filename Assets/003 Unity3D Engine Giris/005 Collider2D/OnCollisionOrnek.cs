using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionOrnek : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ahhhh");
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Dokunmaaa");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Kurtuldum");
    }
}
