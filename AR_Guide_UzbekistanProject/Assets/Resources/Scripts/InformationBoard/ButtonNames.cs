using UnityEngine;

public class ButtonNames : MonoBehaviour
{
    public string buttonName;
    [SerializeField] AudioScript script;
    private void Awake()
    {
        script = FindObjectOfType<AudioScript>();
    }
    private void Start()
    {
        buttonName = gameObject.name;
    }
    public void ChangeTheName()
    {
        script.ButtonName = buttonName;
    }
}
