using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEditor.Animations;
using UnityEngine;

public class GetBigger : MonoBehaviour
{
    [SerializeField] public Vector3 scale;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GetBig();
            Destroy(gameObject);
        }
    }


    private void GetBig()
    {
        LevelManager.Instance.Players[0].transform.localScale = scale;
    }
    
    
}
