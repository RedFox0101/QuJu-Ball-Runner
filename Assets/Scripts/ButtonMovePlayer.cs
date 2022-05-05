using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMovePlayer : MonoBehaviour,  IPointerClickHandler
{
    [SerializeField]
    private  Player _player;
    [SerializeField]
    private int horizontal;
    private void OnEnable()
    {
        EventHolder.PlayerAction += GetPlayer;
    }
    private void OnDisable()
    {
        EventHolder.PlayerAction -= GetPlayer;
    }
  
    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    _player.Move(horizontal);
    //}

    //public void OnPointerUp(PointerEventData eventData)
    //{
    //    _player.Move(0);
    //}


    private void GetPlayer(Player value)
    {
        _player = value;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _player.Move(horizontal);
    }
}
