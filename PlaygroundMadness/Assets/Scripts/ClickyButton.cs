using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickyButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image imgg;
    [SerializeField] private Sprite defaultt, pressedd;
    [SerializeField] private AudioClip compressClip, uncompressClip;
    [SerializeField] private AudioSource sourcee;
        
    public void OnPointerDown(PointerEventData eventData)
    {
        imgg.sprite = pressedd;
        sourcee.PlayOneShot(compressClip);
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        imgg.sprite = defaultt;
        sourcee.PlayOneShot(uncompressClip);
        throw new System.NotImplementedException();
    }
    
}
