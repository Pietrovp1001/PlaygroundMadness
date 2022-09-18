using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider slider;
    public GameObject boss;
    public GameObject healthBar;
    private void Start()
    {
        slider.maxValue = boss.GetComponent<Health>().InitialHealth;
    }
    
    private void Update()
    {
        slider.value = boss.GetComponent<Health>().CurrentHealth;
        if (slider.value <= 0)
        {
            healthBar.SetActive(false);
        }
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = boss.GetComponent<Health>().CurrentHealth;;
        slider.value = boss.GetComponent<Health>().CurrentHealth;;
    }
    
    
}
