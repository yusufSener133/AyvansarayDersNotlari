using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveCompanent : MonoBehaviour
{
    [SerializeField] DirectionEnum _directionEnum;
    Rigidbody2D _rg;
    [SerializeField] float _dusmanHareketHizi;
    void Start()
    {
        _rg = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        _rg.velocity = DirectionSelect() * Time.deltaTime * _dusmanHareketHizi;
    }

    Vector2 DirectionSelect()
    {
        if (Input.GetKey(KeyCode.B))
        {

        }
        Vector2 _directionVector2;
        if (_directionEnum == DirectionEnum.Left)
        {
            _directionVector2 = Vector2.left;
        }
        else
        {
            _directionVector2 = Vector2.right;
        }
        return _directionVector2;
    }
}
