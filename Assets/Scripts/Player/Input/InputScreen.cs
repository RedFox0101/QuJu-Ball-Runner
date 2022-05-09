using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class InputScreen : MonoBehaviour, IInput
{
    [SerializeField] private Camera _camera;

    private float _screenCenter;

    private void Start()
    {
        _camera = Camera.main;
        _screenCenter = _camera.orthographicSize/2;
    }

    public Vector2 GetDirection()
    {
        var mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            if (mousePosition.x > _screenCenter)
            {
                return Vector2.right;
            }
            else if (mousePosition.x < _screenCenter)
            {
                return Vector2.left;
            }
        }

        return Vector2.zero;
    }
}
