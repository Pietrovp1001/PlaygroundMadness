using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject bullet;
    public ParticleSystem explosion;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            bullet.GetComponent<SpriteRenderer>().enabled = false;
            explosion.Play();
        }

    }
    
    
}
