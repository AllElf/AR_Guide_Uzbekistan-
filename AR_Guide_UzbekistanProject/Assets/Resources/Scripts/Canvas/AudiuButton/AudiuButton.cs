using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiuButton : MonoBehaviour
{
    [SerializeField]AudioSource audioSource;
    [SerializeField]Animator animator;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    public void Play()
    {
        
        animator.enabled = !animator.enabled;
        if(animator.enabled == true)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
    
    private void Update()
    {
        if (audioSource.isPlaying)
        {
            animator.enabled = true;
        }
        else
        {
            animator.enabled = false;
        }
    }
    public void Stop()
    {
        audioSource.Stop();

    }
}
