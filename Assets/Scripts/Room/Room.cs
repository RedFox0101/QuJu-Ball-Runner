using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Transform Begin;
    public Transform End;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * _speed * Time.fixedDeltaTime);
    }
}
