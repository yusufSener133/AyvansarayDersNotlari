using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerControllerAnim : MonoBehaviour
{
    Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        AttackYap();
        Yuru();
        Zipla();
    }

    void AttackYap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.Play("CharacterAttack");
        }
    }

    void Yuru()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _animator.Play("CharacterWalk");
            
        }
    }

    void Zipla()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.Play("CharacterJump");
        }
    }
}

