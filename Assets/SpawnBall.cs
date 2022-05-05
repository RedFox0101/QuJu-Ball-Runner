using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
   
    private Player _ball;
    [SerializeField]
    private GameObject _effect;
 
    [SerializeField]
    private Timer _timer;
    private void OnEnable()
    {
        EventHolder.PlayerAction += GetPlayer;
    }
    private void OnDisable()
    {
        EventHolder.PlayerAction -= GetPlayer;
    }

    private void GetPlayer(Player value)
    {
        _ball = value;
    }
   
    private void Start()
    {
        _timer.gameObject.SetActive(true);
        _timer.PlayTimer();
      
       
        Time.timeScale = 0;
    }


   private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform") && Singelton.instant.IsSpawn == true)
        {
            _ball.transform.parent = null;
            Singelton.instant.IsSpawn = false;

            _ball.gameObject.transform.position = new Vector2(collision.transform.position.x + 0.5f, collision.transform.position.y + 0.5f);
           
                Instantiate(_effect, _ball.transform);
            

        }
    }
  
   
}
