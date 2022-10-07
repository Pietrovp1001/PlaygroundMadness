using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemiesBoss : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject boss;
    private void Update()
    {
        if (boss.GetComponent<Health>().CurrentHealth <= 50)
        {
           SpawnEnemies();
           enemies.Clear();
        }
    }
    
    public void SpawnEnemies()
    {
        foreach (var spawnObject in enemies)
        {
            GameObject instanceObject = Instantiate(spawnObject, boss.transform.position, quaternion.identity) as GameObject;
           
        }
    }    
    
}
