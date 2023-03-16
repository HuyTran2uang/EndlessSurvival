using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Player _player;

    public void LoadData()
    {

    }

    private void Start()
    {
        _player = new Warrior();
    }
}

public enum CharacterType
{
    Warrior,
    Thief,
    Mage
}