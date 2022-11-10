using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseTitle : MonoBehaviour
{
    public GameObject title;
    public Vector2 direction;

    void Start()
    {
        LeanTween.moveY(title, direction.x, direction.y).setEaseInOutCubic().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
