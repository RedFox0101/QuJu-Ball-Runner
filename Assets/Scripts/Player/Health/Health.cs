using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _amout;

    public UnityAction<int> _UpdateHealth;
    public UnityAction Dead;

    private void Start()
    {
        _UpdateHealth?.Invoke(_amout);
    }
    public void Add()
    {
        _amout++;
        _UpdateHealth?.Invoke(_amout);
    }

    public void TakeDamage()
    {
        _amout--;
        _UpdateHealth?.Invoke(_amout);
        if (_amout <= 0)
        {
            Dead?.Invoke();
        }
    }
}
