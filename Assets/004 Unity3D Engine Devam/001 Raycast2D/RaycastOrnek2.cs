using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastOrnek2 : MonoBehaviour
{
    [SerializeField] Transform _hitHorizontal, _hitVertical;

    RaycastHit2D hit2DRight, hit2DLeft, hit2DUp, hit2DDown;
    List<RaycastHit2D> Hits;
    private void Awake()
    {
        Hits = new List<RaycastHit2D>() { hit2DRight, hit2DLeft, hit2DUp, hit2DDown };
    }
    private void FixedUpdate()
    {
        IsinGonderHorizontal();
        IsinGonderVertical();
        Hareket();
        foreach (RaycastHit2D item in Hits)
        {
            if (item.collider != null)
            {
                item.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

            }
            //if (hit2DRight.collider != null)
            //    hit2DRight.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            //if (hit2DLeft.collider.gameObject.tag == "Enemy")
            //    hit2DLeft.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            //if (hit2DUp.collider.gameObject.tag == "Enemy")
            //    hit2DUp.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            //if (hit2DDown.collider.gameObject.tag == "Enemy")
            //    hit2DDown.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.black;

        }
    }

    void Hareket()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, 100 * Time.deltaTime);
        }
    }
    void IsinGonderHorizontal()
    {
        hit2DRight = Physics2D.Raycast(_hitHorizontal.position, _hitHorizontal.forward, Mathf.Infinity);
        //Hits.Add(hit2DRight);
        Debug.DrawRay(_hitHorizontal.position, _hitHorizontal.forward * 100, Color.blue);

        hit2DLeft = Physics2D.Raycast(_hitHorizontal.position, _hitHorizontal.forward, -Mathf.Infinity);
        //Hits.Add(hit2DLeft);
        Debug.DrawRay(_hitHorizontal.position, _hitHorizontal.forward * -100, Color.white);
    }
    void IsinGonderVertical()
    {
        hit2DUp = Physics2D.Raycast(_hitVertical.position, _hitVertical.forward, Mathf.Infinity);
        //Hits.Add(hit2DUp);
        Debug.DrawRay(_hitVertical.position, _hitVertical.forward * 100, Color.red);

        hit2DDown = Physics2D.Raycast(_hitVertical.position, _hitVertical.forward, -Mathf.Infinity);
        //Hits.Add(hit2DDown);
        Debug.DrawRay(_hitVertical.position, _hitVertical.forward * -100, Color.black);
    }

}
