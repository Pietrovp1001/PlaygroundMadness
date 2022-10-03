using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreBuyableItem : MonoBehaviour {
    public int price;
    public AudioClip buySound;
    private BoxCollider2D michael;
    private void Start() {
        michael = gameObject.GetComponent<BoxCollider2D>();
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.CompareTag("Player") && Colectable.coinsCollected >= price) {
            michael.enabled = !michael.enabled;
            Colectable.coinsCollected -= price;
            AudioSource.PlayClipAtPoint(buySound, transform.position);
        }
    }
}
