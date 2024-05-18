using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour
{
    public int HitCount;

    public int TotalCount;

    public GameObject Before, After;


    public void WoodHit()
    {
        HitCount += 1;

        if (CheckHits())
        {
            Before.SetActive(false);
            After.SetActive(true);
        }
    }

    bool CheckHits()
    {
        if (HitCount >= TotalCount)
        {
            return true;
        }
        return false;
    }

}
