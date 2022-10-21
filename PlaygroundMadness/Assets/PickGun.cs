using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;

public class PickGun : MonoBehaviour
{
    public Weapon WeaponToPick;
    public string weaponID;
    
    public void Pick()
    {
    LevelManager.Instance.Players[0].GetComponent<CharacterHandleWeapon>().ChangeWeapon(WeaponToPick, weaponID);
    }
    
}
