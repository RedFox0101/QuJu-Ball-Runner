using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private ColectionMove MoveCollections;
    [SerializeField] private float _speed;

    private IMove _move;
    private FabricaMove _fabrica;

    public float Speed => _speed;

    private void Start()
    {
        _move = new NoMove();
        _fabrica = new FabricaMove(MoveCollections, this);
        SetMove(_fabrica.CreateMove());
    }

    private void SetMove(IMove move)
    {
        _move = move;
    }

    private void FixedUpdate()
    {
        transform.Translate(_move.GetDirection());
    }
}

