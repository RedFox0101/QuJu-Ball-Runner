using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTop : IMove
{
    private float speedY;
    Vector3 _vector;
    public MoveTop()
    {
        this.speedY = Singelton.instant.speed;
    }
    public Vector3 Move()
    {
       _vector = new Vector3(0, speedY, 0);
        return _vector;
    }
}
