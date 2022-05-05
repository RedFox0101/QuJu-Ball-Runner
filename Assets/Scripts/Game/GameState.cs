using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class GameState : MonoBehaviour
{

  
    private Player _player;
    private AudioSource _sound;
    private MobAdsRewarded _mobAdsRewarder;
    private bool _isRewardedShow = false;
    [SerializeField]
   
    public GameObject Panel_GameOver;
    public GameObject Panel_Pause;
    public GameObject Panel_Reclama;
    
    public GameObject Effect;
    public Timer Timer;

    private void Start()
    {
        _mobAdsRewarder = GetComponent<MobAdsRewarded>();
        _player = Singelton.instant.Player;
        _sound = this.GetComponent<AudioSource>();
        OnResetData();
    }
    private void Update()
    {
       
            if ( Input.GetKey(KeyCode.Escape) && Panel_GameOver.activeSelf==false&& Panel_Reclama.activeSelf==false)
            {
              Panel_Pause.SetActive(true);
            SoundPlay();
            Time.timeScale=0;
                
            }
           

    }
    private void OnEnable()
    {
        EventHolder.LifeAction += GameOver;
    }
    private void OnDisable()
    {
        EventHolder.LifeAction -= GameOver;
    }
    private void OnResetData()
    {
        Data.LifeCount = 3;
        Data.CoinCount = 0;

        if (GameInformation.Score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", GameInformation.Score);
        }
        GameInformation.Score = 0;
    }
    private void GameOver(int life)
    {
      
        if (life < 1)
        {
        
            PlayerPrefs.SetInt("Coins", Data.CoinCount + PlayerPrefs.GetInt("Coins"));
            if (_isRewardedShow == false)
            {
                
                    Time.timeScale = 1;
                    GameInformation.isScore = false;
                    Panel_Reclama.SetActive(true);
                    _player.gameObject.SetActive(false);

                
            }
            else
            {
               
                Time.timeScale = 1;
                _player.gameObject.SetActive(false);
                GameInformation.isScore = false;
                Panel_GameOver.SetActive(true);
            }
        }
    }
   
    private void SoundPlay()
    {
        _sound.Play();
    }

    public void Restart()
    {
      
        Time.timeScale = 1;
        GameInformation.isScore = true;
        SoundPlay();
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        SoundPlay();
      
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
     
    }

    public void Close()
    {
        SoundPlay();

        Panel_Pause.SetActive(false);
        Timer.gameObject.SetActive(true);
        Timer.PlayTimer();
       
    }

    public void ShowAdMob()
    {
        _mobAdsRewarder.ShowRewardedAd();
    }

    public void NoShowAdmob()
    {
        Time.timeScale = 1;
        Panel_Reclama.SetActive(false);
        Panel_GameOver.SetActive(true);
    }

    public void Respawn()
    {

            Time.timeScale = 1;
        Singelton.instant.IsSpawn = true;
             Instantiate(Effect, _player.transform);
    
           _player.gameObject.SetActive(true);
       
            Data.LifeCount = 3;
            Panel_Reclama.SetActive(false);
            _isRewardedShow = true;
            GameInformation.isScore = true;
      
    }

   
}
