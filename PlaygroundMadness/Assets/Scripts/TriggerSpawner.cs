using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    public Spawner Spawner;
    private bool used = false;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && used == false)
        {
            Spawner.SpawnObject();
            used = true;
        }
    }
}
