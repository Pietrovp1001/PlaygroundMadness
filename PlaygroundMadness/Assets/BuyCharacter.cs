using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

public class BuyCharacter : MonoBehaviour
{
    public Text buyedText;
    public int skinPrice;
    public MMFeedbacks buyedFeedbacks;
    public MMFeedbacks notBuyedFeedbacks;
    public SpriteRenderer CoinSprite;
    
    public void BuyCharacter1()
    {
        if (SkinCoinsManager.totalSkinCoinsEarned >= skinPrice)
        {
            SkinCoinsManager.totalSkinCoinsEarned -= skinPrice;
            buyedText.text = "Select";
            buyedFeedbacks.PlayFeedbacks();
            Destroy(CoinSprite);
        }
        else
        {
            notBuyedFeedbacks.PlayFeedbacks();
        }
    }
}
