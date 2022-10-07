using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using Unity.VisualScripting;
using UnityEngine;

public class BossSwitchWeapon : MonoBehaviour
{
    public Weapon NewWeapon;
    protected CharacterHandleWeapon _characterHandleWeapon;
    protected int _change = 0;
    public GameObject boss;
    private void Update()
    {
        if (boss.GetComponent<Health>().CurrentHealth <= 50)
        {
            ChangeWeapon();
            
        }
    }


    protected virtual void ChangeWeapon()
    {
        if (_change < 1)
        {
            if (NewWeapon == null)
            {
                boss.GetComponent<CharacterHandleWeapon>().ChangeWeapon(NewWeapon, "");
            }
            else
            {
                boss.GetComponent<CharacterHandleWeapon>().ChangeWeapon(NewWeapon, NewWeapon.name);
            }
                
            _change++;
        }
    }
    
    
}
