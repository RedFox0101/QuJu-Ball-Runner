using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusTimer : MonoBehaviour
{
    public Image TimerBonus;
    
    public bool IsTimerWorks=true;
    [HideInInspector]
    public int CoolDown;
    public void StartTimer()
    {

        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        IsTimerWorks = true;

        TimerBonus.fillAmount = 1;
        
        while (TimerBonus.fillAmount != 0)
        {
            if (CoolDown > 0)
            {
                TimerBonus.fillAmount -= 0.01f / CoolDown;
            }
            else
            {
                TimerBonus.fillAmount -= 0.01f / 5;
            }
            yield return new WaitForFixedUpdate();

        }
          IsTimerWorks = false;


}
}
