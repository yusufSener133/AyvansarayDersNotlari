using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveCompanent : MonoBehaviour
{
    Rigidbody2D _rg;
    [SerializeField] float _dusmanHareketHizi;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        _rg.velocity = Vector2.left * Time.deltaTime * _dusmanHareketHizi;
    }

}
