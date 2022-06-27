using UnityEngine;

public class MagnitBonus : Bonus
{
    private ContainerEffecor _effector;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out ContainerEffecor effector))
        {
            _effector = effector;
            Do();
        }
    }

    protected override void Effect()
    {
        this.transform.position = new Vector2(-5, -10);
        Timer = ContainerBonusTimers.Instants.TimerMagniteBonus;
        _effector.StartEffect();
        Timer.Completed += Stop;
       
    }

    private void Stop()
    {
        Timer.Completed -= Stop;
        _effector.StopEffect();
        Destroy(gameObject);
    }
}
