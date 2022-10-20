using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialWallEnemy : MonoBehaviour
{
    private BoxCollider2D triggerCollider;
    public List<GameObject> boxes = new List<GameObject>();

    public void Start() {
        triggerCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            triggerCollider.enabled = !triggerCollider.enabled;
            for (int i = 0; i < boxes.Count; i++) {
                StartCoroutine(BoxesAnim());
            }
        }
    }
    IEnumerator BoxesAnim() {
        for (int i = 0; i < boxes.Count; i++) {
            boxes[i].GetComponent<Animator>().SetBool("UpCajita", true);
        }
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < boxes.Count; i++) {
            boxes[i].SetActive(false);
        }
    }
}
