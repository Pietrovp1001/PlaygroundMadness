 using System.Collections;
using System.Collections.Generic;
 using Unity.Mathematics;
 using UnityEngine;
 using Random = UnityEngine.Random;

 public class WaveSpawner : MonoBehaviour
{
   public List<Enemy> enemies = new List<Enemy>();
   public int waveValue;
    public int currentWave;
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
  
    public Transform spawnPoint;
    public int waveDuration;
    private float waveTimer;
    private float spawnInterval;
    public float spawnTimer;
    
    void Start()
    {
        GenerateWave();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnTimer <= 0)
        {
            if (enemiesToSpawn.Count > 0)
            {
                Instantiate(enemiesToSpawn[0], spawnPoint.position, Quaternion.identity);
                enemiesToSpawn.RemoveAt(0);
                spawnTimer = spawnInterval;
            }
            else
            {
                waveTimer -= Time.fixedDeltaTime;
                spawnTimer -= Time.fixedDeltaTime;
                
            }
        } 
    }

    public void GenerateWave()
    {
        waveValue = currentWave * 10;
        GenerateEnemies();
        
        spawnInterval= waveDuration / enemiesToSpawn.Count;
        waveTimer = waveDuration;
    }

    public void GenerateEnemies()
    {
        List<GameObject> generatedEnemies = new List<GameObject>();
        while (waveValue >0)
        {
            int randomEnemyID = Random.Range(0, enemies.Count);
            int randomEnemyCost = enemies[randomEnemyID].cost;
            
            if(waveValue - randomEnemyCost >= 0)
            {
                waveValue -= randomEnemyCost;
                generatedEnemies.Add(enemies[randomEnemyID].enemyPrefab);
            }
            else if (waveValue <= 0)
            {
                break;
            }
        }
    }
    [System.Serializable]
    public class Enemy
    {
        public GameObject enemyPrefab;
        public int cost;
    }
    
    
}
