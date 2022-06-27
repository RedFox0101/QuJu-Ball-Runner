using UnityEngine;

public class CoinMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;

    private void FixedUpdate()
    {
       Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            enabled = false;
        }
    }

    public void Start(Transform target)
    {
        _target = target;
    }
}
