using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public List<GameObject> spawnToObject = new List<GameObject>();
    public List<ParticleSystem> spawnEffects = new List<ParticleSystem>();
    public List<GameObject> doors = new List<GameObject>();
    public RoomCounter roomCounter;
    public GameObject bossPortal;
    private Animator cajitas;
    
    
    
    //public int roomCount = LevelManager.Instance.Players[0].GetComponent<RoomCounter>().roomCount;

    public int enemyCount;

    public bool isRandom;
    public int waveCount = 1;

    private void Start()
    {
        cajitas = GetComponent<Animator>();
        for (int i = 0; i < doors.Count; i++)
        {
            doors[i].SetActive(false);
        }
    }

    public void SpawnObject()
    {
        for (int i = 0; i < doors.Count; i++)
        {
            doors[i].SetActive(true);
        }

        enemyCount = spawnToObject.Count;
        for (int i = 0; i < spawnToObject.Count; i++)
        {
            int indexEnemy = isRandom ? Random.Range(0, enemiesToSpawn.Count) : 0;
            if (enemiesToSpawn.Count > 0)
            {
                GameObject enemy = Instantiate(enemiesToSpawn[indexEnemy], spawnToObject[i].transform.position, Quaternion.identity);
                enemy.GetComponent<Health>().OnDeath += EnemyCount;
                spawnEffects[i].Play();
            }
        }

    }

    private void EnemyCount()
    {
        enemyCount--;

        if (enemyCount == 0)
        {
            if (waveCount > 0)
            {
                SpawnObject();
                waveCount--;
            }
            else
            {
                for (int i = 0; i < doors.Count; i++)
                {
                    cajitas.SetTrigger("upcaj");
                    doors[i].SetActive(false);
                    if (LevelManager.Instance.Players[0].GetComponent<RoomCounter>().roomCount == 10)
                    {
                        bossPortal.SetActive(true);
                    }
                }
            }
        }
    }

}

