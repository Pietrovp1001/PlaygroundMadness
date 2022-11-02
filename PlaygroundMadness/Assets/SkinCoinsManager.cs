using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinCoinsManager : MonoBehaviour
{
    public static int totalSkinCoinsEarned= 99;

    public void CollectCoins()
    {
        totalSkinCoinsEarned += 1;
    }
    
}
