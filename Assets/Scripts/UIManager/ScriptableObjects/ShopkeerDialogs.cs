using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopKeeperDialogBox", menuName = "ScriptableObjects/ShopKeeperDialog", order = 1)]

public class ShopkeerDialogs : ScriptableObject
{
    public string[] GemStrings;
    public string StartingDialog;
    public string[] BoughtDialog;
    public string[] SellDialog;
    public string[] EquipDialog;
    public string[] NoMoney;
}
