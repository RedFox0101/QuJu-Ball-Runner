using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    [SerializeField] private ItemView _itemView;

    private int _isBuy = 1;

    private void OnEnable()
    {
        _itemView.Buy += OnBuy;
    }

    private void OnDisable()
    {
        _itemView.Buy -= OnBuy;
    }

    public void OnBuy(Item item)
    {
        if (item.IsBuy == true)
        {
            PlayerPrefs.SetInt("BallIndex", item.IndexPlayer);
        }

        else if (PlayerPrefs.GetInt("Coins") >= item.Price)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - item.Price);

            PlayerPrefs.SetInt(item.Name, _isBuy);
        }
    }
}



