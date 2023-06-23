using UnityEngine;

public class CanvasTouch : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    void Start()
    {
            _canvas = GetComponent<Canvas>();
            _canvas.worldCamera = Camera.main;
        
    }
}
