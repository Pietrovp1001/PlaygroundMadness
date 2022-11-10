using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinCoinsCounter : MonoBehaviour
{
  
  public Text skinCoinsText;
  
  private void Awake()
  {
        
      skinCoinsText = GetComponent<Text>();
  }

  private void Update()
  {
        
      skinCoinsText.text = SkinCoinsManager.totalSkinCoinsEarned.ToString();
        
  }
  }
