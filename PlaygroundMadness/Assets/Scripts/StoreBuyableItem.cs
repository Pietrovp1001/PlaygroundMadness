using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using MoreMountains.InventoryEngine;
using MoreMountains.Tools;
using UnityEngine;
using MoreMountains.TopDownEngine;

public class StoreBuyableItem : MonoBehaviour {
    
    public int price;
    public ItemPicker itemPicker;
    public MMFeedbacks buyFeedback;
    public GameObject item;
    public PowerUp powerUp;
    public float giveHealth;
    
    
    public void BuyItem()
    {
        if (Colectable.coinsCollected >= price)
        {
            Colectable.coinsCollected -= price;
            itemPicker.Pick();
            buyFeedback.PlayFeedbacks();
            Destroy(item);
        }
    }
    public void BuySpeedPowerUp()
    {
        if (Colectable.coinsCollected >= price)
        {
            Colectable.coinsCollected -= price;
            powerUp.SpeedUpgrade();
            buyFeedback.PlayFeedbacks();
            Destroy(item);
        }
    }
    public void BuyHealtPowerUp()
    {
        if (Colectable.coinsCollected >= price)
        {
            Colectable.coinsCollected -= price;
            powerUp.HealthUpgrade();
            buyFeedback.PlayFeedbacks();
            Destroy(item);
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }
    
    public void BuyStimpack()
    {
        if (Colectable.coinsCollected >= price)
        {
            Colectable.coinsCollected -= price;
            Health characterHealth = LevelManager.Instance.Players[0].GetComponent<Health>();
            characterHealth.ReceiveHealth(giveHealth, gameObject);
            buyFeedback.PlayFeedbacks();
            Destroy(item);
        }
    }
    
    
}
