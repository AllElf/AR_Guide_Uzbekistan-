using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] string AudioToolsName;
    public string ButtonName;
    [SerializeField] string ScriptManagerName = "ScriptManager";
    [SerializeField] GameObject AudioToolsObject;
    public AudioSource audioSource;
    [SerializeField] FindAnimatorIsObj _findAnimatorIsObj;
    [SerializeField] GameObject ButtonAssist;
    public AudioNameObject audioNameTrack;
    [SerializeField] GameObject[] Landmark;
    [SerializeField] AudioSource[] AllAudio;
    [SerializeField] GameObject[] ButtonInformationBoard;


    private void Awake()
    {
        AllAudio = FindObjectsOfType<AudioSource>();
        for(int i = 0; i < AllAudio.Length; i++)
        {
            AllAudio[i].Stop();
        }
        AudioToolsObject = GameObject.Find(AudioToolsName);
        AudioToolsObject.SetActive(false);
        
    }
    private void Start()
    {
        //ButtonAssist = GameObject.Find(ButtonName);
        //ButtonAssist.SetActive(false);
        audioSource = GameObject.Find("NullAudio").GetComponent<AudioSource>();
        ButtonInformationBoard = GameObject.FindGameObjectsWithTag("ButtonInformationBoard");
        for(int i = 0; i < ButtonInformationBoard.Length; i++)
        {
            ButtonInformationBoard[i].SetActive(false);
        }
    }
    
    public void ClickSehriyo()
    {
        _findAnimatorIsObj = GameObject.Find(ScriptManagerName).GetComponent<FindAnimatorIsObj>();
        Landmark = GameObject.FindGameObjectsWithTag("Landmark");
        for (int i = 0; i < AllAudio.Length; i++)
        {
            AllAudio[i].Stop();
        }
        for(int i = 0; i < Landmark.Length; i++)
        {
            Landmark[i].gameObject.SetActive(false);
        }
        AudioToolsObject.SetActive(true);
        for (int i = 0; i < ButtonInformationBoard.Length; i++)
        {
            if (ButtonInformationBoard[i].name == ButtonName)
            {
                ButtonInformationBoard[i].SetActive(true);
            }
        }

    }
    public void Play()
    {
        audioSource.Play();
    }
    public void Pause()
    {
        audioSource.Pause();
    }
    public void Stop()
    {
        audioSource.Stop();
    }
    public void ExitPanel()
    {
        audioSource.Stop();
        AudioToolsObject.SetActive(false);
        for (int i = 0; i < ButtonInformationBoard.Length; i++)
        {
            ButtonInformationBoard[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (audioSource.isPlaying)
        {
            _findAnimatorIsObj.on_offAnimatorHuman = true;
        }
        else if (!audioSource.isPlaying)
        {
            _findAnimatorIsObj.on_offAnimatorHuman = false;
        }
    }
}
