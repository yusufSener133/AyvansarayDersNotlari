using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRendererOrnek : MonoBehaviour
{
    /*
    Sprite Renderer :   Unity'de 2D veya 3D oyunlarda kullanillan oyun nesnelerinde (objelerde) gosterilmek istenen grafik goruntuleridir.

    Sprite ile image birbirleriyle karistirilmamalidir. Bir objeye sprite atandiginde otomatik olarak o objeye spriteRenderer companenti eklenir.
    
    Sprite           :  Grafigin secilecegi goruntu yoludur.
    Color            :  Renklendirmek icin kullanilir.
    Flip             :  Sprite i isaretlenen eksen yonunde dondurur.
    Material         :  Sprite dokusunu belirlemek icin kullanilir.
    DrawMode         :  Boyutlari degistiginde sprite'in nasil olceklenegini tanimlar.
    Mask Interaction :  SpriteRenderer'in bir obje ile etkilsim kurarken nasil davranicagini belirler. Baska bir obje olusturulur ve ona "spriteMask" ozelligi atanarak kullanilir.
            none                 :   Hicbiri
            visible inside Mask  :   SpriteMask'in onu kapladigi yerde gorunur, disinda gozukmez.
            visible outside Mask :   SpriteMask'in onu kapladigi yer disinda gorunur, icinde gozukmez.
    Order In Layer   :  Sprite katman siralamasini belirlemek icin kullanilir.

    */
}
