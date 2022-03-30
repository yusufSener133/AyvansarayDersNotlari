using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHit : MonoBehaviour
{
    [SerializeField] GameObject _mermi;
    private void FixedUpdate()
    {
        IsinGonder(this.transform);
    }

    void IsinGonder(Transform _transform)
    {
        RaycastHit2D hit = Physics2D.Raycast(_transform.position,_transform.forward,Mathf.Infinity);
        Debug.DrawRay(_transform.position, _transform.forward);
        if (hit.collider != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
