using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class RoomWinCounter : MonoBehaviour
{
    //public RoomCounter Room;
    private Text _text;
    public Slider slider;
    
    
    
    private void Update()
    {
        slider.value = LevelManager.Instance.Players[0].GetComponent<RoomCounter>().roomCount;
    }
    
}

