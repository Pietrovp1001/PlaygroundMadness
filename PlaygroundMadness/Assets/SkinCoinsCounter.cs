using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinCoinsCounter : MonoBehaviour
{
  public int skinCoinsManager;
  public Text skinCoinsText;
  
  void Update()
  {
   FindObjectOfType<SkinCoinsManager>().totalSkinCoinsEarned = skinCoinsManager;
    skinCoinsText.text = skinCoinsManager.ToString();
  }
}
