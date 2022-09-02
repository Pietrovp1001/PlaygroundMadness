using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSpawner : MonoBehaviour
{
    //public GameObject EarlyTrigger;
    //[SerializeField] GameObject Activator;
    public Spawner Spawner;
    private bool used = false;
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.CompareTag("Player") && used == false)
        {
            RoomCounter rooms = col.GetComponent<RoomCounter>();
            if (rooms.roomCount > 0)
            {
                Spawner.SpawnObject();
                used = true;
                rooms.roomCount++;
            }
            else
            {
                rooms.roomCount++;
                used = true;
            }
        }
    }
}
