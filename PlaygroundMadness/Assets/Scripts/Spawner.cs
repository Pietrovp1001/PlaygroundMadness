using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using MoreMountains.TopDownEngine;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public List<GameObject> spawnToObject = new List<GameObject>();
    public List<ParticleSystem> spawnEffects = new List<ParticleSystem>();
    
    
    public float currentTimeToSpawn;
    private float timeToSpawn;
    public bool isTimer;
    public bool isRandom;

    private void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    private void Update()
    {
        if (isTimer)
        {
            UpdateTimer();
        }
    }

    private void UpdateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        int indexEnemy = isRandom ? Random.Range(0, enemiesToSpawn.Count) : 0;
        for (int i = 0; i < spawnToObject.Count; i++) {
            if (enemiesToSpawn.Count > 0) {
                Instantiate(enemiesToSpawn[indexEnemy], spawnToObject[i].transform.position, Quaternion.identity);
                spawnEffects[i].Play();
            }
        }
    }
}
