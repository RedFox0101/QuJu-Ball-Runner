using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "CoinBonus", fileName = "CoinBonus")]
public class CoinEffect : EffectBonus
{
    public override void Effect()
    {
        
        Data.CoinCount++;
    }
}
