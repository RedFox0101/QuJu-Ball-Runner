using UnityEngine;

public class DamagePlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Health health))
        {
            health.TakeDamage();
            Destroy(gameObject);
        }
    }
}
