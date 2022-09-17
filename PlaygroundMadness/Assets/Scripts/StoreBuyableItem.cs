using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreBuyableItem : MonoBehaviour
{
    //public int actualCoins;
    public int price;
    
    private BoxCollider2D michael;

    private void Start() {
        michael = gameObject.GetComponent<BoxCollider2D>();
    }
    public void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("Player") && Colectable.coinsCollected >= price) {
            michael.enabled = !michael.enabled;
            Colectable.coinsCollected -= price;
        }
    }
}
