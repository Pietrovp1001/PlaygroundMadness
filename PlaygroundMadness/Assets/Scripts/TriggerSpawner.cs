using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Transactions;
using MoreMountains.TopDownEngine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawner : MonoBehaviour
{
    public Spawner Spawner;
    public ObstacleSpawner ObstacleSpawner;
    private bool used = false;
    public GameObject locked;
    public GameObject playerPos;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            playerPos.SetActive(true);
            locked.SetActive(false);
            if (used == false) {
                RoomCounter rooms = col.GetComponent<RoomCounter>();
                if (rooms.roomCount > 0) {
                    Spawner.SpawnObject();
                    ObstacleSpawner.SpawnObstacle();
                    used = true;
                    rooms.roomCount++;
                } else {
                    rooms.roomCount++;
                    used = true;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            playerPos.SetActive(false);
        }
    }
}
