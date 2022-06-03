using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _particalPrefab;

    private Camera _camera;
    private IInput _input;
    private Rigidbody2D _rigidBody;
    private SpriteRenderer _spriteRenderer;

    public readonly int IndexPlayer;

    private void Start()
    {
        _input = GetComponent<InputKeyBoard>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        Move(_input.GetDirection());
    }

    private void Move(Vector2 direction)
    {
        _rigidBody.velocity = direction * _speed;
        OppositeEnd();
        LookAway(direction);
    }

    private void OppositeEnd()
    {
        if (transform.position.x < _camera.GetEdgeCamera().Item1)
        {
            transform.position = new Vector3(_camera.GetEdgeCamera().Item2, transform.position.y);
        }
        if (transform.position.x > _camera.GetEdgeCamera().Item2)
        {
            transform.position = new Vector3(_camera.GetEdgeCamera().Item1, transform.position.y);
        }
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

    public void ActivePartical()
    {
        var partical = Instantiate(_particalPrefab, transform.position, Quaternion.identity);
        Destroy(partical, 0.5f);
    }
}
