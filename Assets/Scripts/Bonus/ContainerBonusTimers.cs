using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerBonusTimers : MonoBehaviour
{
    public static ContainerBonusTimers Instants;

    public BonusTimer TimerMagniteBonus;

    public void Start()
    {
        Instants = this;
    }
}
