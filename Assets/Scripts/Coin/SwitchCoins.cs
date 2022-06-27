using UnityEngine;

public class SwitchCoins : MonoBehaviour
{
    private Coin[] _coins;

    private void Start()
    {
        _coins = GetComponentsInChildren<Coin>();
    }

    private void OnEnable()
    {
        if (_coins == null)
            return;
        TurnOnCoins(_coins);
    }

    private void TurnOnCoins(Coin[] coins)
    {
        foreach (var coin in coins)
        {
            coin.transform.SetParent(transform);
            coin.SetStartPosition();
            coin.gameObject.SetActive(true);
        }
    }
}
