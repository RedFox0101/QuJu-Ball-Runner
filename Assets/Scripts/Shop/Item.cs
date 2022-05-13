using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Players")]
public class Item : ScriptableObject
{
    [SerializeField] private int _price;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;
    [SerializeField]private int _indexPlayer;

    public int Price => _price;
    public string Name => _name;
    public Sprite Icon => _icon;
    public bool IsBuy => PlayerPrefs.GetInt(_name.ToString()) == 1;
    public int IndexPlayer => _indexPlayer;

}