using UnityEngine;

public class MagnitBonus : Bonus
{
    private PointEffector2D _pointEffector;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PointEffector2D pointEffector2D))
        {
            Timer = ContainerBonusTimers.Instants.TimerMagniteBonus;
            _pointEffector = pointEffector2D;
            transform.position= new Vector2(-5, -10);
            Do();
                
        }
    }

    protected override void Effect()
    {
        _pointEffector.enabled = true;
    }

    private void Update()
    {
        if (Timer.IsTimerWorks == false)
        {
            _pointEffector.enabled = false;
            Destroy(gameObject);    
        }
    }
}
