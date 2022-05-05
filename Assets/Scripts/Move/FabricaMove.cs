using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaMove {

    private IMove _move;
    private int _random;
    private ColectionMove _typeMove;
    private Move param;
    public FabricaMove(ColectionMove type, Move param)
    {
        _typeMove = type;
        this.param = param;
       
        CreateMove();
    }

    public IMove CreateMove()
    {
        switch (_typeMove)
        {
            case ColectionMove.Up:
                _move = new MoveTop();
                break;
            case ColectionMove.Horizontal:
                _move = new HorizontalMove(param);
                break;
            case ColectionMove.Random:
                _random = Random.Range(0, 5);

                if (_random == 0)
                {
                    _move = new HorizontalMove(param);
                }
                else
                {
                    _move = new NoMove();
                }
                break;
            case ColectionMove.None:
                _move = new NoMove();
                break;
            
        }
        return _move;
    }
}
