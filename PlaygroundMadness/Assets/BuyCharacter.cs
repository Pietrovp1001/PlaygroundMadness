using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuyCharacter : MonoBehaviour
{
    public Text buyedText;
    public int skinPrice;
    public MMFeedbacks buyedFeedbacks;
    public MMFeedbacks notBuyedFeedbacks;
    public SpriteRenderer CoinSprite;
    public Character skin;
    public LevelManager levelManager;
    private bool buyed;
    
    public void BuyCharacter1()
    {
        if (buyed == false)
        {
            if (SkinCoinsManager.totalSkinCoinsEarned >= skinPrice)
            {
                SkinCoinsManager.totalSkinCoinsEarned -= skinPrice;
                buyedFeedbacks.PlayFeedbacks();
                Destroy(CoinSprite);
                buyed = true;
                buyedText.text = "Select";
                //GameManager.Instance.StoreSelectedCharacter(skin);
            }
            else
            {
                notBuyedFeedbacks.PlayFeedbacks();
            }
        }
        else
        {
            buyedText.text = "Selected";
            levelManager.PlayerPrefabs[0] = null;
            levelManager.PlayerPrefabs[0] = skin;
            //GameManager.Instance.StoreSelectedCharacter(skin);
        }
    }
    
    
}
