using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButtonActivator : MonoBehaviour
{
    [Tooltip("Arrastrar Boton de interactuar aqui")]
    public GameObject button;

    public void OnTriggerEnter2D(Collider2D col)
    {
        button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        button.SetActive(false);
    }
}
