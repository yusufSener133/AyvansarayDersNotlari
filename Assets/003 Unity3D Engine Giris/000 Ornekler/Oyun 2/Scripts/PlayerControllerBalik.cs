using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerBalik : MonoBehaviour
{
    [SerializeField] GameObject _kamera, _yokOlanDuvar ,_konusmaText2, _neredeText, _yenidenBaslaButton;
    [SerializeField] Text  _gorevText;
    [SerializeField] Image _gorevImage;

    Vector3 _mesafe;
    int _sayacSari, _sayacYesil, _hiz = 5;
    void Start()
    {
        _mesafe = _kamera.transform.position - transform.position;
        StartCoroutine(Nerede());
    }

    void Update()
    {
        _kamera.transform.position = transform.position + _mesafe;
    }
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * _hiz * Time.deltaTime, Input.GetAxis("Vertical") * _hiz * Time.deltaTime);
        Donus();

    }
    void Donus()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_sayacSari == 5 && collision.gameObject.tag == "Enemy")
        {
            _konusmaText2.SetActive(true);
            _yenidenBaslaButton.SetActive(true);
            _hiz = 7;
            _yokOlanDuvar.SetActive(false);
            _gorevImage.color = Color.green;
            _gorevText.text = $"{_sayacYesil} / 10";

        }
        switch (collision.gameObject.tag)
        {
            case "yemSari":
                Destroy(collision.gameObject);
                _sayacSari++;
                _gorevText.text = $"{_sayacSari} / 5";
                break;
            case "yemYesil":
                break;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
            _konusmaText2.SetActive(false);
    }

   IEnumerator Nerede()
    {
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _neredeText.SetActive(false);
        
    }
}
