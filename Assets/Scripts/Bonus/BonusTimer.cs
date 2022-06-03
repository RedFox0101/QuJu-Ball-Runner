using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BonusTimer : MonoBehaviour
{
    [SerializeField] private Image _iconTimer;

    public bool IsTimerWorks { get; private set; }

    public void StartTimer(float coolDown)
    {
        StartCoroutine(Timer(coolDown));
    }

    IEnumerator Timer(float coolDown)
    {
        IsTimerWorks = true;
        _iconTimer.fillAmount = 1;
        while (_iconTimer.fillAmount != 0)
        {
            if (coolDown > 0)
            {
                _iconTimer.fillAmount -= 0.01f / coolDown;
            }
            yield return new WaitForFixedUpdate();
        }
        this.gameObject.SetActive(false);
        IsTimerWorks = false;
    }
}
