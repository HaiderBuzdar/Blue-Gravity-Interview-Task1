using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClotheSellPurchasePanel : MonoBehaviour
{
    public ShopkeerDialogs _DialogsObject;

    public GameObject[] Bought, NotBought;

    public int[] SuitPrices,SellPrice;

    public string SuitString = "Suit";

    public Text[] BuyPrices, SellPrices;

    public Text DialogText;



    private void OnEnable()
    {
        SetUI();
        SetDialog(ShopKeeperDialogType.FirstCome);
    }

    public void SetUI()
    {
        for (int i = 0; i < Bought.Length; i++)
        {
            if (i == 0)
            {
                //Do nothing
            }
            else
            {
                if (PlayerPrefs.GetInt(SuitString + i, 0) == 1)
                {
                    Bought[i].SetActive(true);
                    SellPrices[i].text = SellPrice[i].ToString();
                    NotBought[i].SetActive(false);
                }
                else
                {
                    Debug.Log(i);
                    Bought[i].SetActive(false);
                    NotBought[i].SetActive(true);
                    BuyPrices[i].text = SuitPrices[i].ToString();
                }
            }
            
        }
    }

    public void SetDialog(ShopKeeperDialogType a)
    {
        switch (a)
        {
            case ShopKeeperDialogType.FirstCome:
                DialogText.text = _DialogsObject.StartingDialog;
                break;
            case ShopKeeperDialogType.Buy:
                DialogText.text = _DialogsObject.BoughtDialog[Random.Range(0, _DialogsObject.BoughtDialog.Length)];
                break;
            case ShopKeeperDialogType.Sell:
                DialogText.text = _DialogsObject.SellDialog[Random.Range(0, _DialogsObject.SellDialog.Length)];
                break;
            case ShopKeeperDialogType.Equip:
                DialogText.text = _DialogsObject.EquipDialog[Random.Range(0, _DialogsObject.EquipDialog.Length)];
                break;
            case ShopKeeperDialogType.NoMoney:
                DialogText.text = _DialogsObject.NoMoney[Random.Range(0, _DialogsObject.NoMoney.Length)];
                break;
            case ShopKeeperDialogType.Gems:
                DialogText.text = _DialogsObject.GemStrings[0];
                break;
        }
    }
    public void GemSold()
    {
        DialogText.text = _DialogsObject.GemStrings[1];
    }
    public void BoughtSuit(int x)
    {
        if (PrefManager.GetCoins() >= SuitPrices[x])
        {
            PlayerPrefs.SetInt(SuitString + x, 1);
            PrefManager.SetCoins(-SuitPrices[x]);
            SetUI();
            UIManager.Instance.SetCoins();
            SetDialog(ShopKeeperDialogType.Buy);
        }
        else if (PrefManager.GetGems() >= 1)
        {
            SetDialog(ShopKeeperDialogType.Gems);
            UIManager.Instance.SellGemPanel.SetActive(true);
        }
        else
        {
            SetDialog(ShopKeeperDialogType.NoMoney);
        }
    }

    public void EquipSuit(int x)
    {
        PlayerCostumeManager.Instance.SetSuit(x);
        SetDialog(ShopKeeperDialogType.Equip);
    }

    public void SellSuit(int x)
    {
        PlayerPrefs.SetInt(SuitString + x, 0);
        PrefManager.SetCoins(SellPrice[x]);
        SetUI();
        UIManager.Instance.SetCoins();
        SetDialog(ShopKeeperDialogType.Sell);
        PlayerCostumeManager.Instance.SetSuit(0);

    }

}
