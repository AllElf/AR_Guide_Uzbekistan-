using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AssistentManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject content;
    [SerializeField] GameObject[] textLanguage;
    [SerializeField] string[] textLanguagesNames;

    

    private void Start()
    {
        content = GameObject.Find("ContentView");
        mainMenu = GameObject.Find("ContentLanguageView");
        mainMenu.SetActive(true);
        textLanguage = GameObject.FindGameObjectsWithTag("TextLanguage");
  
        for (int i = 0; i < textLanguage.Length; i++)
        {
            textLanguage[i].GetComponent<Text>().enabled = false;
            textLanguagesNames[i] += textLanguage[i].name;
        }
               content.SetActive(false);
    }
    public void RusText()
    {
        content.SetActive(true);
        mainMenu.SetActive(false);
        for(int i = 0; i < textLanguagesNames.Length; i++)
        {
            textLanguage[i].GetComponent<Text>().enabled = false;
            if (textLanguagesNames[i] == "Text (rus)")
            {
                textLanguage[i].GetComponent<Text>().enabled = true;
            }
        }
    }
    public void EngText()
    {
        content.SetActive(true);
        mainMenu.SetActive(false);
        for (int i = 0; i < textLanguagesNames.Length; i++)
        {
            textLanguage[i].GetComponent<Text>().enabled = false;
            if (textLanguagesNames[i] == "Text (eng)")
            {
                textLanguage[i].GetComponent<Text>().enabled = true;
            }
        }
    }
    public void UzbText()
    {
        content.SetActive(true);
        mainMenu.SetActive(false);
        for (int i = 0; i < textLanguagesNames.Length; i++)
        {
            textLanguage[i].GetComponent<Text>().enabled = false;
            if (textLanguagesNames[i] == "Text (uzb)")
            {
                textLanguage[i].GetComponent<Text>().enabled = true;
            }
        }
    }
    public void BackMainMenu()
    {
        mainMenu.SetActive(true);
        content.SetActive(false);
        for (int i = 0; i < textLanguage.Length; i++)
        {
            textLanguage[i].GetComponent<Text>().enabled = false;
        }

    }


}
