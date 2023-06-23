using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationHumanScripts : MonoBehaviour
{

    [SerializeField] FindAnimatorIsObj _findAnimatorIsObj;
    private void Start()
    {
        _findAnimatorIsObj = FindObjectOfType<FindAnimatorIsObj>();
    }

    public void Speak()
    {
        
        _findAnimatorIsObj.on_offAnimatorHuman = !_findAnimatorIsObj.on_offAnimatorHuman;
    }
        
   
}
