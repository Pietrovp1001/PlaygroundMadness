using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinCoinsManager : MonoBehaviour
{
    public static int totalSkinCoinsEarned= 99;

    private void Awake()
    {
       LoadCoinsAmount();
    }
    
    public void CollectCoins()
    {
        totalSkinCoinsEarned += 1;
        PlayerPrefs.SetInt("totalSkinCoinsEarned", totalSkinCoinsEarned);
    }

    public void LoadCoinsAmount()
    {
        totalSkinCoinsEarned = PlayerPrefs.GetInt("totalSkinCoinsEarned", totalSkinCoinsEarned);
    }
    
    
}
