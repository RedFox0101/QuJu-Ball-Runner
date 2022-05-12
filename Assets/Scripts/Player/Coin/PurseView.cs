using UnityEngine;
using TMPro;
using Zenject;

public class PurseView : MonoBehaviour
{
    [SerializeField] private TMP_Text _countCoins;
    [Inject] private ContainerPlayers _collectionPlayers;

    private Purse _purse;

    private void OnEnable()
    {
        if (_collectionPlayers.TryGetPlayerComponent(ref _purse))
        {   
            _purse.UpdateCountCoints += UpdateCoins;
        }
    }

    private void OnDisable()
    {
        _purse.UpdateCountCoints -= UpdateCoins;
    }

    private void UpdateCoins(int count)
    {
        _countCoins.text = count.ToString();
    }
}
