using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    [SerializeField] private Transform myPosition;

    private void LateUpdate() {
        Vector2 newPosition = myPosition.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
    }
}
