using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlman
{
    /*
    Interface bol ve yonettir.
    Katagorize etme mantigidir.
    */
    public bool AlmanMi { get; set; }
    public void AlmanIndirimiYap();
    public void AlmanMersedesIndirimiYap();
}
public interface IFransiz
{
    /*
    Interface bol ve yonettir.
    Katagorize etme mantigidir.
    */
    public bool FransizMi { get; set; }
    public void FransizIndirimiYap();
    public void FransizMersedesIndirimiYap();
}


