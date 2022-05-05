using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MagnitBonus", fileName = "Magnit")]
public class MagnitEffect : EffectBonus
{
    
    public override void Effect()
    {
        Singelton.instant.StartEffect(0);
    }


}
