using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimAttackParametrer : MonoBehaviour
{
     public Animator enemyAnimator;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            enemyAnimator.SetTrigger("isAttacking");
            Debug.Log("Player is in range");
        }
    

}
}
