using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class BossPortalInvoke : MonoBehaviour
{

    [SerializeField] private GameObject bossPortal;
    public Spawner spawners;
    public Transform playerPosition = LevelManager.Instance.Players[0].GetComponent<Transform>();
    
    void Update()
    {
        
        if( LevelManager.Instance.Players[0].GetComponent<RoomCounter>().roomCount == 10  || spawners.enemyCount == 0)
        {
            CreatePortal();
        }
     
    }
    
    private void CreatePortal()
    {
        Instantiate(bossPortal).transform.position = playerPosition.position;
        spawners.enemyCount = 1;
    }
}
