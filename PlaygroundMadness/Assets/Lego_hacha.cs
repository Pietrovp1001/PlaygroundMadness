using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lego_hacha : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    IEnumerator cooldown()
    {
        animator.SetBool("cooldown", true);
        Debug.Log("not  ready");
        yield return new WaitForSeconds(.7f);
        animator.SetBool("cooldown", false);
        Debug.Log("ready");
    }
}
