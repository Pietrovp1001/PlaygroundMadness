using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage imagex;
    [SerializeField] private float _x, _y;
    void Update()
    {
        imagex.uvRect = new Rect(imagex.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, imagex.uvRect.size);
    }
}
