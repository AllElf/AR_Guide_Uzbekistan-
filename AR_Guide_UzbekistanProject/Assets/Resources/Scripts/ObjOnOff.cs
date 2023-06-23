using UnityEngine;

public class ObjOnOff : MonoBehaviour
{
    [SerializeField] GameObject obj;

    private void Start()
    {
        obj.SetActive(false);
    }
    public void On()
    {
        obj.SetActive(true);
    }
    public void Off()
    {
        obj.SetActive(false);
    }
}
