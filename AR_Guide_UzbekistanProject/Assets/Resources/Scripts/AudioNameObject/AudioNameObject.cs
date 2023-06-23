using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNameObject : MonoBehaviour
{
    public AudioSource audioTrack;
    [SerializeField]string ScriptManagerName = "ScriptManager";
    [SerializeField] AudioScript audioScript;
    [SerializeField] FindAnimatorIsObj _findAnimatorIsObj;
    AudioSource[] audioSources;

    private void Start()
    {
        _findAnimatorIsObj = GameObject.Find(ScriptManagerName).GetComponent<FindAnimatorIsObj>();
        audioTrack = GetComponent<AudioSource>();
    }
    public void AudioNameTrack()
    {
        _findAnimatorIsObj = GameObject.Find(ScriptManagerName).GetComponent<FindAnimatorIsObj>();
        audioScript.audioSource = audioTrack;
    }
    //private void Update()
    //{
    //    for(int i = 0; i < audioSources.Length; i++)
    //    {
    //        if(audioSources[i] == audioTrack)
    //        {
    //            if(audioScript.audioSource.isPlaying)
    //            {
    //                _findAnimatorIsObj.on_offAnimatorHuman = true;
    //            }
    //            else if (!audioScript.audioSource.isPlaying)
    //            {
    //                _findAnimatorIsObj.on_offAnimatorHuman = false;
    //            }
    //        }
    //    }
    //}
}
