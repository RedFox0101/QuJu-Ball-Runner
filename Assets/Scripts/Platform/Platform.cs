using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private ColectionMove MoveCollections;
    [SerializeField] private float _speed;
    [SerializeField] private float _bounceForce;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.transform.SetParent(transform);
            player.ActivePartical();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
}

