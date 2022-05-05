using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class Move : MonoBehaviour
{
    protected IMove _move;
    
    public Vector3 PerformMove()
    {

        return _move.Move();
    }

    public void setMove(IMove move)
    {
        _move = move;
    }

}
