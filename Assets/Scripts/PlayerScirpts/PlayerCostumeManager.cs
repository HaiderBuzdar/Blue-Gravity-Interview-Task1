using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCostumeManager : MonoBehaviour
{
    public static PlayerCostumeManager Instance;

    public SpriteRenderer _PlayerHood, PlayerTorso, _PlayerPelvis;

    public Sprite[] Hoods, Torsos, Pelvises;


    private void Awake()
    {
        Instance = this;
    }

    public void SetSuit(int x)
    {
        _PlayerHood.sprite = Hoods[x];
        PlayerTorso.sprite = Torsos[x];
        _PlayerPelvis.sprite = Pelvises[x];
    }
}
