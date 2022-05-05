using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventHolder
{
    public static Action<int> LifeAction;
    public static Action<int> CoinAction;
    public static Action<int> CoinsShopAction;
  
    public static void RaiseLifeAction(int value)
    {
        LifeAction?.Invoke(value);
    }

    public static void RaiseCoinAction(int value)
    {
        CoinAction?.Invoke(value);
    }

    public static void RaiseCoinsShopAction(int value)
    {
        CoinsShopAction?.Invoke(value);
    }

   
}
