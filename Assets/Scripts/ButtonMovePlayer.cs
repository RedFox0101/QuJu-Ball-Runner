using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMovePlayer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
   
    private  Player _player;
    [SerializeField]
    private int horizontal;

    private void Start()
    {
        _player = Singelton.instant.Player;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        _player.Move(horizontal);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _player.Move(0);
    }
}
