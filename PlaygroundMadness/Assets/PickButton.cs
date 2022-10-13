using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickButton : MonoBehaviour
{
    public void Pick()
    {
        Input.GetKeyDown("space");
        Debug.Log("Picked");
    }
}
