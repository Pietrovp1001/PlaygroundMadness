using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurorialWallBricks : MonoBehaviour
{
    public List<GameObject> boxes = new List<GameObject>();
    public List<GameObject> bricks = new List<GameObject>();
    private int totalBricks = 3;
    private int brickCounter;

    private void Update() {
        RemainingBricks();
        BrickCheck();
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

    private void RemainingBricks() {
        brickCounter = 0;
        for (int i = 0; i < totalBricks; i++) {
            if (bricks[i].GetComponent<BoxCollider2D>().enabled == false) {
                ++brickCounter;
            }
        }
    }
    private void BrickCheck() {
        if (brickCounter == totalBricks) {
            for (int j = 0; j < boxes.Count; j++) {
                StartCoroutine(BoxesAnim());
            }
        }
    }
}
