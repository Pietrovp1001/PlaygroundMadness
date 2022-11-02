using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class ResetStats : MonoBehaviour
{

    public void ResetRoomCount()
    {
        LevelManager.Instance.PlayerPrefabs[0].GetComponent<RoomCounter>().roomCount = 0;
    }
    
}
