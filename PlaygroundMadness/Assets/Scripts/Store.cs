using MoreMountains.InventoryEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public List<GameObject> guns = new List<GameObject>();
    public List<GameObject> lifes = new List<GameObject>();
    public List<GameObject> powerups = new List<GameObject>();

    public List<GameObject> itemPositions = new List<GameObject>();
    public GameObject[] existingItems = new GameObject[3];
    public List<int> prices = new List<int>();

    private int randomPos;

    private void Start() {
        GenerateItems();
    }
    private void Update() {
        
    }
    private void GenerateItems() {
        randomPos = Random.Range(0, guns.Count);
        Instantiate(guns[randomPos], itemPositions[0].transform.position, Quaternion.identity);

        randomPos = Random.Range(0, powerups.Count);
        Instantiate(powerups[randomPos], itemPositions[1].transform.position, Quaternion.identity);

        randomPos = Random.Range(0, lifes.Count);
        Instantiate(lifes[randomPos], itemPositions[2].transform.position, Quaternion.identity);
    }
   /* public void BuyableCheck() {
        for (int i = 0; i < itemPositions.Count; i++) {
            if (Colectable.coinsCollected < prices[i]) {
                if (existingItems[i].GetComponent<BoxCollider2D>().enabled == true) {
                    existingItems[i].GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            if (Colectable.coinsCollected >= prices[i]) {
                if (existingItems[i].GetComponent<BoxCollider2D>().enabled == false) {
                    existingItems[i].GetComponent<BoxCollider2D>().enabled = true;
                }
            }
        }
    }*/
}
