using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Spawner.SpawnObject();
            used = true;
        }
    }
    
    /*if (Activator.gameObject.activeInHierarchy)
     {
     Debug.Log("YES");
     Spawner.gameObject.SetActive(false)
     Early.first = false;
     } 
    else {
    Debug.Log("fuck");
    Spawner.gameObject.SetActive(false);
    Early.first = true;
    }*/
}
