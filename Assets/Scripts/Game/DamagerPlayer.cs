using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerPlayer : MonoBehaviour
{
    [SerializeField] private SpawnerBall _spawnBall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Health health))
        {
            health.TakeDamage();
            _spawnBall.Spawn();
        }        
    }
}
