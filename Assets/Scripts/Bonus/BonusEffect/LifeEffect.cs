using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "LifeBonus", fileName = "LifeBonus")]
public class LifeEffect : EffectBonus
{
    public bool IsLife;

    

    public override void Effect()
    {
       
        if (IsLife==true)
        {
            Data.LifeCount++;
           
        }
        else
        {
            Data.LifeCount--;
        }
       

    }
}
