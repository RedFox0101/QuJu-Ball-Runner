using System.Linq;
using UnityEngine;

public class ContainerPlayers : MonoBehaviour
{
    [SerializeField] private Player[] _players;

    private Player _currentPlayer;
    
    private void Awake()
    {
        ActiveSelectedPlayer(PlayerPrefs.GetInt("BallIndex"));
    }

    private void ActiveSelectedPlayer(int playerIndex)
    {
        _currentPlayer = _players.First(player => player.IndexPlayer == playerIndex);
        _currentPlayer.gameObject.SetActive(true);
    }

    public bool TryGetPlayerComponent<T>(ref T component)
    {
        if (_currentPlayer.gameObject.TryGetComponent(out T getComponent))
        {
            component = getComponent;
            return true;
        }
        throw new System.NullReferenceException($"Нет {component} компонетна в Игроке");
        
    }


}
