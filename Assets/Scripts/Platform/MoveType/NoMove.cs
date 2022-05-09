using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMove : IMove
{
    public Vector3 GetDirection()
    {
        return new Vector3(0, 0, 0);
    }
}
