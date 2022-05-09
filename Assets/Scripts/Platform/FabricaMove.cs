using UnityEngine;

public class FabricaMove
{
    private IMove _move;
    private ColectionMove _typeMove;
    private Move _platforma;

    public FabricaMove(ColectionMove type, Move platforma)
    {
        _typeMove = type;
       _platforma = platforma;
        CreateMove();
    }

    public IMove CreateMove()
    {
        switch (_typeMove)
        {
            case ColectionMove.Up:
                _move = new MoveTop(_platforma);
                break;
            case ColectionMove.Horizontal:
                _move = new HorizontalMove(_platforma);
                break;
            case ColectionMove.Random:
                RandomMovementType();
                break;
            case ColectionMove.None:
                _move = new NoMove();
                break;

        }
        return _move;
    }

    private IMove RandomMovementType()
    {
        int chanve = Random.Range(0, 3);

        if (chanve == 0)
        {
            _move = new HorizontalMove(_platforma);
        }

        return new NoMove();
    }
}
