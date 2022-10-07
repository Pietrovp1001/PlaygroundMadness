using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDummy : MonoBehaviour
{
    public TutorialManager tutorialManager;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            tutorialManager.actualStep = 4;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            tutorialManager.actualStep = 1;
        }
    }
}
