using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class BossPhase : MonoBehaviour
{
    [SerializeField] public Animator bossAnimator;
    [SerializeField] private Image bossHealthBar;
    [SerializeField] public Color bossHealthBarColor;
    [SerializeField] public GameObject boss;
    [SerializeField] public int vidaNecesariaParaTransformarse;
    
    private void Update()
    {
        if (boss.GetComponent<Health>().CurrentHealth <= vidaNecesariaParaTransformarse)
        {
            bossAnimator.SetBool("Tranformarse", true);  
            bossHealthBar.color = bossHealthBarColor;
        }
    }
    
    
}
