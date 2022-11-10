using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class ResetStats : MonoBehaviour
{
    public void ResetRoomCount()
    {
        FindObjectOfType<RoomCounter>().roomCount = 0;
    }
    
}
