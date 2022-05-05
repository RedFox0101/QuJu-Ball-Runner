
using System;
using UnityEngine;
using UnityEngine.UI;

public class CoinsLabel : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    private void OnEnable()
    {
        EventHolder.CoinsShopAction += UpdateCoins;
    }

    private void Start()
    {

        _text.text = "x" + Convert.ToString(PlayerPrefs.GetInt("Coins"));
    }

    private void UpdateCoins(int value)
    {
        _text.text = "x" + Convert.ToString(value);
        Debug.Log("Coins");
    }

    private void OnDisable()
    {
        EventHolder.CoinsShopAction -= UpdateCoins;
    }
}
