using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogType
{
    public Interactions _EnvIntractionType;
    public string DialogText;
}
public enum Interactions
{
    Coin,
    CoinMakerBlock,
    Monument,
    ClotheShope,
    GraveYard,
    OldWell,
    Gems
}
public enum ShopKeeperDialogType
{
    FirstCome,
    Buy,
    Sell,
    Equip,
    NoMoney,
    Gems
}

public class EnumManagers 
{
    
}
