using UnityEngine;

public class CustomPointerEffector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out CoinMover mover))
        {
            mover.Start(transform);
            mover.enabled = true;     
        }
    }
}
