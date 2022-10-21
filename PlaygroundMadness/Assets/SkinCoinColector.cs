using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;

public class SkinCoinColector : MonoBehaviour
{
    public MMFeedback PickedUpSkinCoins;
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            FindObjectOfType<SkinCoinsManager>().totalSkinCoinsEarned += 1;
        }
    }
}
