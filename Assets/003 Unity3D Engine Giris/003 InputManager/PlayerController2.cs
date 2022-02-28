using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //*[SerializeField] bool _solAktifMi;
    //*[SerializeField] bool _sagAktifMi;
    [SerializeField] float _hiz;
    Rigidbody2D RB2D;
    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //*if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //*{
        //*    _solAktifMi = true;
        //*    _sagAktifMi = true;
        //*}
        float ziplama = Input.GetAxis("Jump") * _hiz * Time.deltaTime;
        transform.position += new Vector3(Input.GetAxis("Horizontal") * _hiz * Time.deltaTime, Input.GetAxis("Vertical") * _hiz * Time.deltaTime);

    }

    void FixedUpdate()
    {

    }

}
