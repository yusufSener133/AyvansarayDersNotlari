using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profilBilgileriScripts : MonoBehaviour
{
    //_ privatedir
    //__ tasiyicidir
    [SerializeField] Text[] _textler;
    string adi, soyadi, adresi, __oyuncuBilgileriText/*tasiyici global degisken method icersindeki islemi baska methodda kullanmayi saglar.*/;
    int yasi, telefonu;


    void Start()
    {
        LetsGo();
    }
    void LetsGo()
    {
        OyuncuBilgileri("yusuf", "sener", "usi", 24, false);
        _textler[0].text = __oyuncuBilgileriText;

        ServerBilgileri("EU1");
        ServerBilgileri("31.206.250.58", "00:0B:DB:82:58:C3");
        ServerBilgileri(true, 144, 22, 14, 3);
        AdminBilgisi("admin", "admin", 00, "admin.admin@admin.com", 0000001100);
    }
    void OyuncuBilgileri(string oyuncuAdi, string oyuncuSoyadi, string oyuncuNickname, int oyuncuID, bool oyuncuBanDurumu)
    {
        __oyuncuBilgileriText = oyuncuAdi + "-" + oyuncuSoyadi + "-" + oyuncuNickname + "-" + oyuncuID + "-" + oyuncuBanDurumu;
    }
    void ServerBilgileri(string neresi)
    {
        _textler[1].text = neresi;
    }
    void ServerBilgileri(string IPadresi, string MACadresi)
    {
        _textler[2].text = IPadresi + "-" + MACadresi;
    }
    void ServerBilgileri(bool serverAcikMi, int oyuncuSayisi, int totalBanSayisi, int totalPermaBanSayisi, int totalMacBanSayisi)
    {
        _textler[3].text = serverAcikMi + "-" + oyuncuSayisi + "-" + totalBanSayisi + "-" + totalPermaBanSayisi + "-" + totalMacBanSayisi;
    }
    void AdminBilgisi(string adi, string soyadi, int yasi, string adresi, int telefonu)
    {
        _textler[4].text = adi + "-" + soyadi + "-" + yasi + "-" + adresi + "-" + telefonu;
    }
}
