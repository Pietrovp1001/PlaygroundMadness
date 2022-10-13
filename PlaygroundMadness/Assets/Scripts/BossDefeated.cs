using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class BossDefeated : MonoBehaviour
{
    public GameObject portal;
    public GameObject boss;
    public ParticleSystem particles;
    
    private void Update()
    {
        if (boss.GetComponent<Health>().CurrentHealth == 0)
        {
            portal.SetActive(true);
        }
    }
 
    
    
}
