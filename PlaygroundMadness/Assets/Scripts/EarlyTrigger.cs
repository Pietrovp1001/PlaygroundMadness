using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyTrigger : MonoBehaviour
{
    //public bool first = false;
    [SerializeField] GameObject Activator;
    private void OnTriggerEnter2D(Collider2D treg) {
        if (treg.gameObject.CompareTag("Player")) {
            Activator.gameObject.SetActive(false);
            Debug.Log("enter");
            
            //first = false;
        }
    }
    private void OnTriggerExit2D(Collider2D treg) {
        if (treg.gameObject.CompareTag("Player")) {
            Activator.gameObject.SetActive(true);
            Debug.Log("exit");
            
            //first = true;
        }
    }
}
