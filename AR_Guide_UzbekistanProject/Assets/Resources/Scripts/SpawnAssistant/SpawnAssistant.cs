
using UnityEngine;

public class SpawnAssistant : MonoBehaviour
{
    public GameObject[] AssistantPrefab;
    public string AssistantName;

    public void CreateAssist()
    {
        GameObject[] assistents = GameObject.FindGameObjectsWithTag("Assistent");
        for (int i = 0; i < assistents.Length; i++)
        {
            Destroy(assistents[i]);
        }
        for (int i = 0; i < AssistantPrefab.Length; i++)
        {
            if(AssistantPrefab[i].name == AssistantName)
            {
               GameObject newObject = Instantiate(AssistantPrefab[i]);
               newObject.name = "Assistent";
            }
        }
        
    }
    public void DestroyAsistant()
    {
        GameObject[] assistents = GameObject.FindGameObjectsWithTag("Assistent");
        for(int i = 0; i < assistents.Length; i++)
        {
            Destroy(assistents[i]);
        }
        //GameObject existingObject = GameObject.Find("Assistent");
        //if (existingObject != null)
        //{
        //    Destroy(existingObject);
        //}
    }
}
