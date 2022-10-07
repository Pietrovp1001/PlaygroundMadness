using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{

    public int healthUpgrade= 0;
    public int speedUpgrade = 0;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
         HealthUpgrade();
         SpeedUpgrade();
        }
    }

    private void HealthUpgrade()
    {
        LevelManager.Instance.Players[0].GetComponent<Health>().MaximumHealth+=healthUpgrade;
        LevelManager.Instance.Players[0].GetComponent<Health>().ResetHealthToMaxHealth();
    }
    
    private void SpeedUpgrade()
    {
        LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().WalkSpeed = speedUpgrade + LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().WalkSpeed;
        LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().ResetSpeed();
    }

}
