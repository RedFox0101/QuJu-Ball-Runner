using UnityEngine;

public abstract class Bonus : MonoBehaviour
{
    [SerializeField] private float _coolDown;
    protected BonusTimer Timer;

    protected void Do()
    {
        Timer.gameObject.SetActive(true);
        Timer.StartTimer(_coolDown);
        Effect();
       
    }

    protected abstract void Effect();
}
