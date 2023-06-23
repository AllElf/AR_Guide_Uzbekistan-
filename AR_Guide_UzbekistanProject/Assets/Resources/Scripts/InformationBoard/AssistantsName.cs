using UnityEngine;

public class AssistantsName : MonoBehaviour
{
    public string AssistantNamePref;
    SpawnAssistant spawnAssistant;

    private void Start()
    {
        spawnAssistant = FindObjectOfType<SpawnAssistant>();
    }
    public void AssistantNameSehriyo()
    {
        AssistantNamePref = "AssistentSehriyo";
        spawnAssistant.AssistantName = AssistantNamePref;
    }
    public void AssistantNameAmirTemur()
    {
        AssistantNamePref = "AssistentAmirTemur";
        spawnAssistant.AssistantName = AssistantNamePref;
    }
    public void AssistantNameNext()
    {
        AssistantNamePref = "AssistantNameNext";
        spawnAssistant.AssistantName = AssistantNamePref;
    }
    public void AssistantNameKukildash()
    {
        AssistantNamePref = "AssistantNameKukildash";
        spawnAssistant.AssistantName = AssistantNamePref;
    }
}
