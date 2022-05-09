using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] Text _countHealthLabel;
    [SerializeField] private ContainerPlayers _collectionPlayers;

    private Health _health;

    private void Start()
    {
        if(_collectionPlayers.TryGetPlayerComponent(ref _health))
        {
            _health._UpdateHealth += UpdateCountHealth;
            Debug.Log("yES");
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
