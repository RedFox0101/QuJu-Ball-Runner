using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "CoinSpawnBonus", fileName = "CoinsSpawnBonus")]
public class CoinSpawnBonus : EffectBonus
{

    public override void Effect()
    {
        Singelton.instant.StartEffect(1);
    }
}
