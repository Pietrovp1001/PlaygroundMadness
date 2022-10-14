using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickButton : MonoBehaviour
{
    
    public GameObject pickButton;
    
    public void ShowButton()
    {
        Color tmp = pickButton.GetComponent<Image>().color;
        tmp.a = 1f;
        pickButton.GetComponent<Image>().color = tmp;
    }

    public void DisableButton()
    {
        Color tmp = pickButton.GetComponent<Image>().color;
        tmp.a = 0f;
        pickButton.GetComponent<Image>().color = tmp;
    }
}
