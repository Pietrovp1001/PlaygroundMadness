using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] steps;
    public int actualStep;
    private BoxCollider2D moveCollider;
    [SerializeField] GameObject door;
    public void Start() {
        moveCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    private void Update() {
        for (int i = 0; i < steps.Length; i++) {
            if (i == actualStep) {
                steps[i].SetActive(true);
            } else {
                steps[i].SetActive(false);
            }
        }

        if (Colectable.coinsCollected >= 3) actualStep = 5;

        /*
        if (actualStep == 1) { // ir a las otras habitaciones
        }
        if (actualStep == 2) { // destuir el bloque
        }
        if (actualStep == 3) { // dashear
        }
        if (actualStep == 4) { // destuir el dummy
        }*/
        if (actualStep == 5) { // ir a la salida
            door.SetActive(false);
        }
    }
    /**/
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            moveCollider.enabled = !moveCollider.enabled;
            actualStep = 1;
        }
    }
}
