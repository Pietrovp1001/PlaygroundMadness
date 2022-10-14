using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{

    public float healthUpgrade= 0;
    public float speedUpgrade = 0;

    /*public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
         HealthUpgrade();
         SpeedUpgrade();
        }
    }
*/
    
    
    
    public void HealthUpgrade()
    {
        LevelManager.Instance.Players[0].GetComponent<Health>().MaximumHealth+=healthUpgrade;
        LevelManager.Instance.Players[0].GetComponent<Health>().ResetHealthToMaxHealth();
    }
    
    public void SpeedUpgrade()
    {
        LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().WalkSpeed = speedUpgrade + LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().WalkSpeed;
        LevelManager.Instance.Players[0].GetComponent<CharacterMovement>().ResetSpeed();
    }

}
