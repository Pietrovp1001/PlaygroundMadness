using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCounter : MonoBehaviour
{
    private Text _text;

    

    private void Awake()
    {
        
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        
        _text.text = Colectable.coinsCollected.ToString();
        
    }
    
}
