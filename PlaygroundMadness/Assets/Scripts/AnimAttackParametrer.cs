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
            enemyAnimator.SetBool("isAttacking", true);
            Debug.Log("Player is in range");
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider2D)
    {
        
        if (otherCollider2D.CompareTag("Player"))
        {
            enemyAnimator.SetBool("isAttacking", false);
            Debug.Log("Player is out of range");
        }

    }
}
