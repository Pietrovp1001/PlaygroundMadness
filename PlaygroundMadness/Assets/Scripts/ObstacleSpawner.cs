using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();
    public bool isRandom;
    public Transform parent;
    
 
    public void SpawnObstacle()
    {
        Instantiate(obstaclesToSpawn[isRandom ? Random.Range(0, obstaclesToSpawn.Count) : 0], parent);
    }
    
    
    

    
}
