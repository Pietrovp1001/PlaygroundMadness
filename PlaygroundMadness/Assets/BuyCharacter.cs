using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;

public class BuyCharacter : MonoBehaviour
{
    public Text buyedText;
    public int skinPrice;
    public MMFeedbacks buyedFeedbacks;
    public MMFeedbacks notBuyedFeedbacks;
    public SpriteRenderer CoinSprite;
    public Character Skin;
    
    public void BuyCharacter1()
    {
        if (SkinCoinsManager.totalSkinCoinsEarned >= skinPrice)
        {
            SkinCoinsManager.totalSkinCoinsEarned -= skinPrice;
            buyedText.text = "Select";
            buyedFeedbacks.PlayFeedbacks();
            Destroy(CoinSprite);
            LevelManager.Instance.PlayerPrefabs[0] = null;
            LevelManager.Instance.PlayerPrefabs[0] = Skin; 
        }
        else
        {
            notBuyedFeedbacks.PlayFeedbacks();
        }
    }
}
