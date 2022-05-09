using UnityEngine;

public class HorizontalMove : IMove
{
    private float _speed;
    private Move _platform;
    private Camera _camera;
    private float _leftEdgeScreen;

    public HorizontalMove(Move platform)
    {
        _camera = Camera.main;
        _leftEdgeScreen = _camera.transform.position.x - _camera.orthographicSize/2;
        
        _platform = platform;
        _speed = platform.Speed;
    }

    public Vector3 GetDirection()
    {
        if (_platform.transform.position.x < _leftEdgeScreen)
        {
            FlipDirection();
        }

        if (_platform.transform.position.x > _camera.orthographicSize)
        {
            FlipDirection();
        }

        return new Vector3(_speed, 0);

    }

    private void FlipDirection()
    {
        _speed *= -1;
    }
}
