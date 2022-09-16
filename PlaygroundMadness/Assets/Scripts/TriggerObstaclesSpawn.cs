using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObstaclesSpawn : MonoBehaviour
{
 
    public ObstacleSpawner Spawner;
    public bool used = false;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player")) {
            if (used == false) {
                RoomCounter rooms = col.GetComponent<RoomCounter>();
                if (rooms.roomCount > 0) Spawner.SpawnObstacle();
                used = true;
                rooms.roomCount++;
            }
        }
    }
}
