using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class FollowIA : MonoBehaviour
{
    public float speed;
   
    public float minimumDistance;
    
    
    
    
    void Update()
    {
        if (Vector2.Distance(transform.position, LevelManager.Instance.Players[0].GetComponent<Transform>().position) > minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, LevelManager.Instance.Players[0].GetComponent<Transform>().position, speed * Time.deltaTime);
        }

        if (gameObject.GetComponent<Health>().CurrentHealth ==0)
        {
            speed = 0;
        }
    }

}
