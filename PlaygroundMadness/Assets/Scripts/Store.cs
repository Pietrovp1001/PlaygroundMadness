using MoreMountains.InventoryEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public List<GameObject> guns = new List<GameObject>();
    public List<GameObject> lifes = new List<GameObject>();
    public List<GameObject> powerups = new List<GameObject>();
    public List<ItemPicker> itemPickers = new List<ItemPicker>();
    public List<GameObject> itemPositions = new List<GameObject>();
    public List<int> prices = new List<int>();
    public Colectable colectable;
    private int randomPos;
    private void Start() {
        //se spawnean los items en las determinadas posiciones

        //valor random para randomPos entre 0 y el count de guns[]
        //spawnear guns[randomPos] en itemPositions[0]

        //valor random para randomPos entre 0 y el count de lifes[]
        //spawnear lifes[randomPos] en itemPositions[1]

        //valor random para randomPos entre 0 y el count de powerups[]
        //spawnear powerups[randomPos] en itemPositions[2]
    }
    void Update() {/*
        if() { //si player entra en contacto con el item
            if (colectable.coinsCollected >= prices[i]) { //si tienes las monedas
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
