using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.Tools;
using MoreMountains.TopDownEngine;

public class InteractableItems : MonoBehaviour
{
    
    public GameObject item;

    public void ActivatePickUp()
    {
        item.AddComponent(typeof(PickableItem));
    }
}
