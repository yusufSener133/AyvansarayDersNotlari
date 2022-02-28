using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Canta
{
    public string Turu { get; set; }
    public int Kapasite { get; set; }
    public float Dayaniklilik { get; set; }
    public bool TakiliMi  { get; set; }
    public bool MatTakilabilir  { get; set; }
    public SpriteRenderer CantaSprite { get; set; }
}
