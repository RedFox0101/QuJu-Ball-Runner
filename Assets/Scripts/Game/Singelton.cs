using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Singelton : MonoBehaviour
{
    [SerializeField]
    private BonusTimer[] _timer;
    private PointEffector2D _effector;
    [HideInInspector]
    public Player Player;
    
    public GameObject Coins;
    public static Singelton instant;

    [HideInInspector]
    public Vector2 CamMin, CamMax;
    public bool IsSpawn=false;
    public float speed = 0.05f;

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
        Player = value;
        _effector = Player.GetComponent<PointEffector2D>();
    }
    private void Awake()
    {
        CamMin = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        CamMax = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        instant = GetComponent<Singelton>();
    }

    private void Start()
    {
       
        StartCoroutine(Speed());
       
    
    }

   
    public void StartEffect(int value)
    {
        _timer[value].gameObject.SetActive(true);
        _timer[value].StartTimer();
       
        if (value == 0)
        {
            MagnitOn();
        }
        else if (value==1)
        {
            StartCoroutine(SpawnCoin());
        }
       
    }
  private void MagnitOn()
    {
        _timer[0].CoolDown = 5;
       _effector.enabled = true;
        StartCoroutine(Magnit());
       
    }


  private void MagnitOff()
    {
        _effector.enabled = false;
        _timer[0].gameObject.SetActive(false);
    }
    IEnumerator SpawnCoin()
    {
        _timer[1].CoolDown = 5;
        while (_timer[1].IsTimerWorks==true)
        {
            Instantiate(Coins, new Vector3(Random.Range(CamMin.x, CamMax.x), 0), Quaternion.identity);
           
            yield return new WaitForSeconds(0.5f);

        }
      
     _timer[1].gameObject.SetActive(false);
    }
    IEnumerator Magnit()
    {
        while (_timer[0].IsTimerWorks==true)
        {
            yield return new WaitForFixedUpdate();
        }

        MagnitOff();
    }
    IEnumerator Speed()
    {
        while (speed < 0.1f)
        {

            speed += 0.0005f;
            yield return new WaitForSeconds(3.5f);
        }
    }
}
