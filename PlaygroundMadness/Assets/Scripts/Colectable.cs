using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Colectable : MonoBehaviour
{
    
    public static int coinsCollected = 99;
    public MMFeedbacks PickedMMFeedbacks;
    
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            coinsCollected++;
            PickedMMFeedbacks?.Initialization(this.gameObject);
            Debug.Log("Coins Collected: " + coinsCollected);
        }
    }

    public void RestartCoins()
    {
        coinsCollected = 0;
    }
}
