using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Colectable : MonoBehaviour
{
    [SerializeField] public static int coinsCollected = 0;
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
}
