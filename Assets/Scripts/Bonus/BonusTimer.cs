using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BonusTimer : MonoBehaviour
{
    [SerializeField] private Image _iconTimer;

    public UnityAction Completed;

    public async void StartTimer(float coolDown)
    {
        await Timer(coolDown);
        this.gameObject.SetActive(false);
    }

    private async Task Timer(float coolDown)
    {
        _iconTimer.fillAmount = 1;
        while (_iconTimer.fillAmount != 0)
        {
            if (coolDown > 0)
            {
                _iconTimer.fillAmount -= 0.01f / coolDown;
            }
            await Task.Yield();
        }
        Completed?.Invoke();
    }
}
