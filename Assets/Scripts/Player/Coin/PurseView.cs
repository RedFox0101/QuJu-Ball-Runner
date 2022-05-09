using UnityEngine;
using TMPro;

public class PurseView : MonoBehaviour
{
    [SerializeField] private TMP_Text _countCoins;
    [SerializeField] private ContainerPlayers _collectionPlayers;

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
