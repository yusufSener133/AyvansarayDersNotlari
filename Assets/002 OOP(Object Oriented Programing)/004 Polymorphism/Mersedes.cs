using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mersedes : Araba
{
    public bool YuzuyorMu { get; set; }

    public override void SatisYap() // ezdik
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 2000m;
        }

        if (YuzuyorMu)
        {
            ToplamFiyati += 10000m;
        }
    }
}
