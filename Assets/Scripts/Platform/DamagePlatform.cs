using UnityEngine;

public class DamagePlatform : MonoBehaviour
{
    private SpawnerBall _spawner;

    private void Start()
    {
        _spawner = FindObjectOfType<SpawnerBall>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Health health))
        {
            health.TakeDamage();
            _spawner.Spawn();
        }
    }
    
}
