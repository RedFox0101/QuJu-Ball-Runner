using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemViewModel : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Item _item;
    [SerializeField] private ItemView _shopView;

    private Image _icon;

    private void Awake()
    {
        _icon = GetComponent<Image>();
        _icon.sprite = _item.Icon;
    }

    private void Start()
    {
        DimmingIcon();
    }

    private void DimmingIcon()
    {
        if (PlayerPrefs.GetInt("BallIndex") == _item.IndexPlayer)
        {
            _shopView.ShowInfo(_item);
        }
        else
        {
            _icon.color = new Color(255, 255, 255, 0.5f);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _shopView.ShowInfo(_item);
    }
}
