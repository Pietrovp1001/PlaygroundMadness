using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyInScenes : MonoBehaviour
{
    public GameObject objectToNotDestroy;
    private void Awake()
    {
        DontDestroyOnLoad(objectToNotDestroy);
    }
}
