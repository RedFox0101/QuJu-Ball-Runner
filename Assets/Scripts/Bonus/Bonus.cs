using UnityEngine;

public abstract class Bonus : MonoBehaviour
{
    [SerializeField] private float _coolDown;
    protected BonusTimer Timer;

    protected void Do()
    {
        Effect();
        Timer.gameObject.SetActive(true);
        Timer.StartTimer(_coolDown);
    }

    protected abstract void Effect();
}
