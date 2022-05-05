using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopBall : MonoBehaviour, IPointerClickHandler
{
   
    private Image _icon;
    [SerializeField]
    private int _sumCoins;
    [SerializeField]
    private string _name;
    [SerializeField]
    private ShopBuy _shopBuy;
    [SerializeField]
    private string _key;
    private AudioSource _sound;
   
    public bool IsBuy;
    public int IndexBall;
    
    private void Awake()
    {
        _sound = this.GetComponent<AudioSource>();
        _icon = GetComponent<Image>();
       
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("BallIndex") == IndexBall)
        {


            DataBalls();
        }
        else
        {
            Debug.Log("Color");
            _icon.color = new Color(255, 255, 255, 0.5f);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {

        _sound.Play();
        DataBalls();
      
    }


    private void DataBalls()
    {
        
        if (PlayerPrefs.GetInt(_key) == 1 || IsBuy == true)
        {
           if (PlayerPrefs.GetInt("BallIndex") == IndexBall)
            {
                _shopBuy.SumLabel.text = "Selected";
                IsBuy = true;
            }
            else
            {
                _shopBuy.SumLabel.text = "Select";
                IsBuy = true;
            }
            
            
        }
       
        else
        {
            IsBuy = false;
            _shopBuy.SumLabel.text = "Buy from " + Convert.ToString(_sumCoins);
        }
        _shopBuy.Icon.sprite = _icon.sprite;
        _shopBuy.NameLabel.text = _name;
        _shopBuy.IsBought = IsBuy;
        _shopBuy.IndexBall = IndexBall;
        _shopBuy.Key = _key;
        _shopBuy.SumCoins = _sumCoins;
    }
}
