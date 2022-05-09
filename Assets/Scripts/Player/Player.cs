using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(InputKeyBoard))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private IInput _input;
    private Rigidbody2D _rigidBody;
    private SpriteRenderer _spriteRenderer;

    public readonly int IndexPlayer;

    private void Start()
    {
        _input = GetComponent<InputKeyBoard>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move(_input.GetDirection());
    }

    public void Move(Vector2 direction)
    {
        _rigidBody.velocity= direction * _speed;
        LookAway(direction);
    }

    private void LookAway(Vector2 direction)
    {
        if (direction.x > 0)
        {
            _spriteRenderer.flipX = true;
        }

        else if (direction.x < 0)
        {
            _spriteRenderer.flipX = false;
        }
    }
}
