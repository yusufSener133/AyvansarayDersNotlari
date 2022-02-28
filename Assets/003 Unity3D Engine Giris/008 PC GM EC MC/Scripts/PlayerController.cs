using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] bool _ZiplayabilirMi;
    [SerializeField] float _ziplamaKuvveti;

    Rigidbody2D _rg;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ZiplayabilirMi = true;
        }
    }

    private void FixedUpdate()
    {
        if (_ZiplayabilirMi)
        {
            _rg.AddForce(Vector2.up * Input.GetAxis("Jump") * _ziplamaKuvveti);
        }

        _ZiplayabilirMi = false;
    }
}
