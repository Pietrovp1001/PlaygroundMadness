using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Colectable : MonoBehaviour
{
    
    public Text coinsText;
    public int coinsCollected = 0;
    private bool isCollected = false;
    
    
    private void Awake()
    {
        coinsText = GetComponent<Text>();
    }
    
    void ShowCoin()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<CircleCollider2D>().enabled = true;
        isCollected = false;
    }
    void HideCoin()
    {
       
        this.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<CircleCollider2D>().enabled = false;
        //Destroy(this.gameObject);
    }
    void CollectCoin()
    {
        isCollected = true;
        HideCoin();
        coinsCollected++;
    }
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Player")
        {
            CollectCoin();
        }
    }
}
