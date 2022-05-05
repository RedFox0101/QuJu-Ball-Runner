using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeControl : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField]
    private Player _player;

    private void OnEnable()
    {
        EventHolder.PlayerAction += GetPlayer;
    }
    private void OnDisable()
    {
        EventHolder.PlayerAction -= GetPlayer;
    }

    private void GetPlayer(Player value)
    {
        _player = value;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0)
            {
                _player.Move(1);
            }
            else
            {
                _player.Move(-1);
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
