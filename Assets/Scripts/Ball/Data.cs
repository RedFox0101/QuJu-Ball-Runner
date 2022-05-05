using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    private static int _lifeCount=3;
    private static int _coinCount=0;

    public static int LifeCount
    {
        get
        {
            return _lifeCount;
        }

        set
        {
            if (value>= 5)
            {
                _lifeCount = 5;
            }
           else if (value <= 0)
            {
                _lifeCount = 0;
            }
            else
            {
                _lifeCount = value;
            }
            EventHolder.LifeAction(_lifeCount);

        }

    }
    
    public static int CoinCount
    {
        get
        {
            return _coinCount;
        }

        set
        {
            _coinCount = value;
            EventHolder.CoinAction(_coinCount);

        }

    }
    
}
