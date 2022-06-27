using UnityEngine;

public class HorizontalMove : IMove
{
    private float _speed;
    private Platform _platform;
    private Camera _camera;
    private float _leftEdgeScreen, _rightEdgeScreen;

    public HorizontalMove(Platform platform)
    {
        _camera = Camera.main;
        _leftEdgeScreen = _camera.GetEdgeCamera().Item1;
        _rightEdgeScreen= _camera.GetEdgeCamera().Item2;
        _platform = platform;
        _speed = platform.Speed;
    }

    public Vector3 GetDirection()
    {
        if (_platform.transform.position.x < _leftEdgeScreen)
        {
            FlipDirection();
        }

        if (_platform.transform.position.x > _rightEdgeScreen-1.2f)
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
