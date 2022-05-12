using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject _panelGameOver;
    [Inject] private ContainerPlayers _containerPlayers;

    private Health _health;

    private void Start()
    {
        if (_containerPlayers.TryGetPlayerComponent(ref _health))
        {
            _health.Dead += GameOver;
        }
    }

    private void OnDisable()
    {
        _health.Dead -= GameOver;
    }

    private void GameOver()
    {
        _panelGameOver.SetActive(true);
        _health.gameObject.SetActive(false);
    }
}
