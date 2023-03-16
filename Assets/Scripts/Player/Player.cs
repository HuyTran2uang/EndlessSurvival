using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Player
{
    public abstract void Intrinsic();
}

public class Warrior : Player
{
    public override void Intrinsic()
    {

    }
}

public class Thief : Player
{
    public override void Intrinsic()
    {

    }
}