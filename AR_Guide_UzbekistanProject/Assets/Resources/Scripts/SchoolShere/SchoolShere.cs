using UnityEngine;

public class SchoolShere : MonoBehaviour
{
    [SerializeField] GameObject _spawn;


    private void Start()
    {
       Instantiate(_spawn,GameObject.FindGameObjectWithTag("PositonNull").transform.position, GameObject.FindGameObjectWithTag("PositonNull").transform.rotation);
    }
}
