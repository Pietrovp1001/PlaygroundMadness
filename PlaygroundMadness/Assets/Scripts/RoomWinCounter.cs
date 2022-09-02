using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class RoomWinCounter : MonoBehaviour
{
    public RoomCounter Room;
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = LevelManager.Instance.Players[0].GetComponent<RoomCounter>().roomCount.ToString();
    }
}

