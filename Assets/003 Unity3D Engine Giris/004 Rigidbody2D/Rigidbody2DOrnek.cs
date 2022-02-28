using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody2DOrnek : MonoBehaviour
{
    /*
    Rigidbody 2D : Rigidbody componenti, Unity fizik motorunu kullanarak gercek dunyada oldugu gibi fiziksel hareketlerin taklit edilmesini saglar.
        
        Yercekimi yuzunden nesnelerin asagi dusmesi, yuvarlak objelerin yuvarlanmasi gibi hareketleri dusunebiliriz ve bu component sayesinde objelere gercekci sekilde hareket yetenegi verebiliyoruz.
        Ornegin bir araba modelinde, tekerlerin dondurme kuvveti (Tork) uygulanarak arabanin ilerlemesini saglanabilir ve rotasyonunu degistirerek sag sola hareket ettirebiliriz.

    Body Type           : 

            Dynamic         : Dinamik oyun nesneleri tamamiyle oyun motoru(Inputlar) tarafindan calistirilir. Dinamik oyun nesnelerinin hareketi kuvvet, hiz vb factorlarden etkilenir. Kullanim Durumu; oyun karakterleri ya da hareketli oyun nesneleri.

            Kinematic       : Kinematik oyun nesneleri tamamen komut dosyalari(moveController) tarafindan yonlendirirler. Bu nedenle hareket bolumunu manuel olarak ele almamiz gerekir. Kullanim Durumu; moveController. Kinematik oyun nesneleri yalnizca dinamik oyun nesneleri ile carpisabilir. Bu gameObject ler onColisionEnter in islenmesini saglar.

            Static          : Static objelere bagli hicbir gercek rigidbody bileseni yoktur. Bu nedenle fizik motoru onlari hareketli olarak gormez. Onlara hicbir carpisma uygulanmaz. OnTrigger ve OnCollision calismayacaktir. Kullanim durumlari; zemin, duvarlar ve carpismasini istemedigimiz oyun objeleri.
    
    UseAutoMass         : Otomatik kutle belirler.

    Mass                : Rigidbodynin kutlesini belirlemek icin kullanilir.

    Linear Drag         : Surtunme Katsayisi (Dogrusal)

    Angular Drag        : Surtunme Katsayisi (Acisal)

    Gravity Scale       : Yercekimi Kuvveti

    Collision Detection : 

            Discrete        : Bu secenegi sectiginde Rigidbodyleri ve collisionlari olan gameObjectler hareket ediyorsa fizik guncellemesi sirasinda (herhangi bir fizik olayinda) ust uste gelebilir ve birbirlerinin icinden gecebilir. 

            Continuous      : Bu secenek secildiginde Rigidbodyleri ve collisionlari olan gameObjectler carpisma sirasinda birbirlerinin icinden gecmezler. Bunun yerine Unity Rigidbodylerden herhangi birinin ilk etki noktasini hesaplar ve gameObjecti oraya tasir. Bu secenek biraz fazla cpu maliyeti gerektirir. 
    
    Sleeping Mode       : 

            Never Sleep     : (Onerilmez) Baslatilmasada calisir.
            Start Awake     : Basladiktan sonra calisir.
            Start Asleep    : Carpisma oldugunda calisir.
    
    Interpolate         : (3D de anlasilir) Hareket gameobjectin onceki karelerdeki konumuna gore yumusatir.
            Nope            : 
            Interpolate     : Bulundugu gidisata gore yumusatma yapar. Hareket gameobjectin onceki karelerdeki konumuna gore yumusatir.
            Extrapolate     : Bulundugu framerate ye gore yumusatma yapar. Hareket sonraki karedeki konuma iliskin tahmine gore calisir. 
    
    Constraints         : Pozisyonu dondurma (Freeze Position X, Y, Freeze Rotation Z)


     */

}
