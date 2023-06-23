using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAnimatorIsObj : MonoBehaviour
{
    public Animator animatorHuman;
    public bool on_offAnimatorHuman;

    private void Start()
    {
        animatorHuman = GameObject.FindGameObjectWithTag("Human").GetComponent<Animator>();
        on_offAnimatorHuman = false;
    }
    private void Update()
    {
        
        if(on_offAnimatorHuman == true)
        {
            animatorHuman.SetBool("isSpeak", true);
        }
        else if (on_offAnimatorHuman == false)
        {
            animatorHuman.SetBool("isSpeak", false);
        }
    }
}
