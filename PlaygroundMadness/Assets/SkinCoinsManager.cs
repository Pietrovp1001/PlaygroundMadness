using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinCoinsManager : MonoBehaviour
{
    public static int totalSkinCoinsEarned;

    public void CollectCoins()
    {
        totalSkinCoinsEarned += 1;
    }
}
