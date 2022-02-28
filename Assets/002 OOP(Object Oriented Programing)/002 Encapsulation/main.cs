using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    /*


    */

    [SerializeField] InputField firstNameInput, lastNameInput, ageInput;

    [SerializeField] Text hataText;
    void Start()
    {
        KirmiziBomba _kirmiziBomba = new KirmiziBomba();
        MaviBomba _maviBomba = new MaviBomba();
        SariBomba _sariBomba = new SariBomba();
        TuruncuBomba _turuncuBomba = new TuruncuBomba();
        _kirmiziBomba.BombaAdi = "bombRed";
        _maviBomba.BombaAdi = "bombBlue";
        _sariBomba.BombaAdi = "bombYellow";
        _turuncuBomba.BombaAdi = "bombOrange";
    }

    void Update()
    {

    }

    void Insan1(insan insan, string firstname, string lastname, int age)//, decimal money)
    {
        insan.FirstName = firstname;
        insan.LastName = lastname;
        insan.Age = age;

        // insan.Money = money; sadece base classtan elisebilir.
        Debug.Log($"Ad ...> {firstname}, Soyad ...> {lastname}, Yas ...>{age}");
    }
    public void ButonaVeriGonder()
    {
        insan _insan1 = new insan();
        Insan1(_insan1, firstNameInput.text, lastNameInput.text, System.Convert.ToInt32(ageInput.text));
    }

}
