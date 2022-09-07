using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedRoom : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject locked;

    private void Update() {
        if (player.position == locked.transform.position) {
            locked.SetActive(false);
        }
    }
    
}
