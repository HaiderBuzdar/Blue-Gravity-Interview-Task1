using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefManager : MonoBehaviour
{
    public static string TotalCoins="TotalCoins";

    public static string TotalGems="TotalGems";



    private void Awake()
    {

    }
    void MakePrefs()
    {
        if (!PlayerPrefs.HasKey(TotalCoins))
        {
            PlayerPrefs.SetInt(TotalCoins, 0);
        }
        if (!PlayerPrefs.HasKey(TotalGems))
        {
            PlayerPrefs.SetInt(TotalGems, 0);
        }
    }

    public static int GetGems()
    {
        return PlayerPrefs.GetInt(TotalGems, 0);
    }
    public static void SetGems(int x)
    {
        PlayerPrefs.SetInt(TotalGems, GetGems() + x);
    }
    public static int GetCoins()
    {
        return PlayerPrefs.GetInt(TotalCoins, 0);
    }

    public static void SetCoins(int x)
    {
        PlayerPrefs.SetInt(TotalCoins, GetCoins() + x);
    }
}
