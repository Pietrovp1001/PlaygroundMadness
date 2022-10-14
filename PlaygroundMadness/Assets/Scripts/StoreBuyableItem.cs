using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreBuyableItem : MonoBehaviour {
    public int price;
    public AudioClip buySound;
    public GameObject storeCollider;
    public GameObject priceText;
    public Store store;
    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("Player")) {
            if (Colectable.coinsCollected >= price) {
                Destroy(priceText);
                storeCollider.GetComponent<BoxCollider2D>().enabled = false;
                Colectable.coinsCollected -= price;
                AudioSource.PlayClipAtPoint(buySound, transform.position);
            }
        }
    }
}
