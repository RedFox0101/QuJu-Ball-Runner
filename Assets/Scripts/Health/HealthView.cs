using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HealthView : MonoBehaviour
{
    [SerializeField] Text _countHealthLabel;
    [Inject] private ContainerPlayers _collectionPlayers;

    private Health _health;

    private void Start()
    {
        if(_collectionPlayers.TryGetPlayerComponent(ref _health))
        {
            _health._UpdateHealth += UpdateCountHealth;
        }
    }

    private void OnDisable()
    {
        _health._UpdateHealth -= UpdateCountHealth;
    }

    private void UpdateCountHealth(int count)
    {
        _countHealthLabel.text = count.ToString();
    }

}
