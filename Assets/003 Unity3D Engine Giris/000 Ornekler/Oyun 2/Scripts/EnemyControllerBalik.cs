using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControllerBalik : MonoBehaviour
{
    [SerializeField] GameObject _konusmaText, _gorevPanel, _yemler;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _konusmaText.SetActive(true);
        _gorevPanel.SetActive(true);
        _yemler.SetActive(true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _konusmaText.SetActive(false);
    }
}
