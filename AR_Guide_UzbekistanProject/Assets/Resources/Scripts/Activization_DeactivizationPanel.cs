using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activization_DeactivizationPanel : MonoBehaviour
{
    [SerializeField] GameObject locations;
    [SerializeField] string _name;
    [SerializeField] bool _enabled = false;

    private void Start()
    {
        locations = GameObject.Find(_name);
        locations.SetActive(false);
        _enabled = false;
    }

    public void Buttonlocations()
    {
        locations.SetActive(true);
    }
    public void ButtonlocationsOff()
    {
        locations.SetActive(false);
    }
   
    
}
