using UnityEngine;

public class AsistantController : MonoBehaviour
{
    [SerializeField] string _positionMoveName;
    [SerializeField] string _cameraPositionName;
    [SerializeField] GameObject _cameraPosition;
    [SerializeField] GameObject _positionMove;
    [SerializeField] Vector3 vec = new Vector3(0, 0.1f, 0);


    private void Start()
    {
        _positionMove = GameObject.Find(_positionMoveName);
        _cameraPosition = GameObject.Find(_cameraPositionName);
    }
    void Update()
    {
        transform.LookAt(_cameraPosition.transform);
        transform.position = Vector3.Lerp(transform.position, _positionMove.transform.position, 1f * Time.deltaTime);
    }
    public void PositionDown()
    {
        
        _positionMove.transform.position -= vec;
    }
    public void PositionUp()
    {

        _positionMove.transform.position += vec;
    }
}
