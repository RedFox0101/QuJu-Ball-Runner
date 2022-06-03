using UnityEngine;

public class MoveTop : IMove
{
    private float _speed;
    
    public MoveTop(Platform platforma)
    {
        _speed = platforma.Speed;
    }
    public Vector3 GetDirection()
    {
         return new  Vector3(0, _speed, 0);   
    }
}
