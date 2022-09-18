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

    //public List<ItemPicker> itemPickers = new List<ItemPicker>();
    //public List<int> prices = new List<int>();
    //public StoreBuyableItem buyable;

    private int randomPos;
    private void Start() {
        randomPos = Random.Range(0, guns.Count);
        Instantiate(guns[randomPos], itemPositions[0].transform.position, Quaternion.identity);
        
        randomPos = Random.Range(0, powerups.Count);
        Instantiate(powerups[randomPos], itemPositions[1].transform.position, Quaternion.identity);
        
        randomPos = Random.Range(0, lifes.Count);
        Instantiate(lifes[randomPos], itemPositions[2].transform.position, Quaternion.identity);
    }
    void Update() {
        /*if(player collides guns[]) { //si player entra en contacto con el item
            if (buyable == true) { //si tienes las monedas
                for (int i = 0; i < itemPickers.Count; i++) {
                    itemPickers[i].SetActive(true); //se asegura que todo itempicker este activo
                    colectable.coinsCollected -= prices[i]; //y luego te descuenta el precio
                }
            } else {                                    //si no
                for (int i = 0; i < itemPickers.Count; i++) {
                    itemPickers[i].SetActive(false); //simplemente desactiva el itempicker
                }
            }
        }*/
    }
}
