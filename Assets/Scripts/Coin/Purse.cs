using UnityEngine;
using UnityEngine.Events;

public class Purse : MonoBehaviour
{
    private int _currentCoins;

    public UnityAction<int> UpdateCountCoints;

    private void Start()
    {
        UpdateCountCoints?.Invoke(_currentCoins);
    }
    public void AddCoins()
    {
        _currentCoins++;
        UpdateCountCoints?.Invoke(_currentCoins);
    }
}
