using UnityEngine;

public class Coin : MonoBehaviour
{
    private Vector3 _startingPosition;

    private void Start()
    {
        _startingPosition = transform.localPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Purse purse))
        {
            purse.AddCoins();
            gameObject.SetActive(false);
        }
    }

    public void SetStartPosition()
    {
        transform.localPosition = _startingPosition;
    }
}
