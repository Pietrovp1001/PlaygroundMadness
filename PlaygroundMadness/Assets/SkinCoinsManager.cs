using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;

public class SkinCoinsManager : MonoBehaviour
{
    public int skinCoins = 0;
    public MMFeedback PickedUpSkinCoins;
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            skinCoins++;
            PickedUpSkinCoins?.Initialization(this.gameObject);
        }
    }
}
