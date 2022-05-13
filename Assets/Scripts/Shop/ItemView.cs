using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemView : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private Text _nameLabel;
    [SerializeField] private Text _priceLabel;
    [SerializeField] private Button _buyButton;

    private Item _item;
    public UnityAction<Item> Buy;

    private void OnEnable()
    {
        _buyButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _buyButton.onClick.RemoveListener(OnButtonClick);
    }

    private void Start()
    {
        ChangeText();
    }

    public void ShowInfo(Item item)
    {
        _item = item;
        _icon.sprite = item.Icon;
        _nameLabel.text = item.Name;
        _priceLabel.text = item.Price.ToString();

        ChangeText();
    }

    private void OnButtonClick()
    {
        Buy?.Invoke(_item);
    }

    private void ChangeText()
    {

        if (PlayerPrefs.GetInt(_item.Name) == 1 || _item.IsBuy == true)
        {
            _priceLabel.text= PlayerPrefs.GetInt("BallIndex")==_item.IndexPlayer ? "Selected" : "Select";
        }
        else
        {
            _priceLabel.text = "Buy from " + _item.Price.ToString();
        }
    }
}
