using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapZoom : MonoBehaviour
{
    [SerializeField] private GameObject minimapVisual;
    [SerializeField] private Camera minimapCamera;
    private bool zoomed = false;

    public void ZoomOut() {
        if (zoomed == false) {
            minimapVisual.GetComponent<RectTransform>().sizeDelta = new Vector2(500, 500);
            minimapCamera.GetComponent<Camera>().orthographicSize = 350;
            zoomed = true;
        } else {
            minimapVisual.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 200);
            minimapCamera.GetComponent<Camera>().orthographicSize = 200;
            zoomed = false;
        }
    }
}
