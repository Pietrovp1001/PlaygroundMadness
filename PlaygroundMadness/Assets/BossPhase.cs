using System;
using System.Collections;
using System.Collections.Generic;
using System.Media;
using MoreMountains.Feedbacks;
using MoreMountains.TopDownEngine;
using Unity.VisualScripting;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class BossPhase : MonoBehaviour
{
    [SerializeField] public Animator bossAnimator;
    [SerializeField] private Image bossHealthBar;
    [SerializeField] public Color bossHealthBarColor;
    [SerializeField] public GameObject boss;
    [SerializeField] public int vidaNecesariaParaTransformarse;
    [SerializeField] public MMFeedbacks bossTransformFeedback;
    
    private void Update()
    {
        if (boss.GetComponent<Health>().CurrentHealth <= vidaNecesariaParaTransformarse)
        {
        
            bossAnimator.SetBool("Tranformarse", true);  
            bossHealthBar.color = bossHealthBarColor; 
            bossTransformFeedback.PlayFeedbacks();
            Destroy(bossTransformFeedback);

        }
    }
    
    
}
