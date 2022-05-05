using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
public class MainMenuManager : MonoBehaviour
{
    private AudioSource _sound;
    private const string _leaderBorder = "CgkI9_K0wPEREAIQAA";
    public Text BestScoreMenu;
    public GameObject ButtonMusicOf;
    public GameObject ButtonMusicOn;
    public static bool IsSound;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            SoundOn();
        }
        else
        {
            SoundOFF();
        }
      
    }
    private void Start()
    {
        _sound = this.GetComponent<AudioSource>();
        BestScoreMenu.text = "Best Score " + Convert.ToString(PlayerPrefs.GetInt("BestScore"));
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate(success =>
        {
            if (success)
            {

            }
            else
            {

            }
        });
        Social.ReportScore(PlayerPrefs.GetInt("BestScore"), _leaderBorder, (bool success) => { });
    }
  
    public void SoundOFF()
    {
        AudioListener.pause = true;
        ButtonMusicOf.SetActive(true);
        ButtonMusicOn.SetActive(false);
        IsSound = true;
        SetSoundGame(false);
    }

    public void SoundOn()
    {
        AudioListener.pause = false;
       
        IsSound = false;

        ButtonMusicOf.SetActive(false);
        ButtonMusicOn.SetActive(true);
        SetSoundGame(true);
    }

    public void Quick()
    {
      
        Application.Quit();

    }

   private void SetSoundGame(bool Play)
    {
        if (Play == true)
        {
            PlayerPrefs.SetInt("Sound", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Sound", 1);
        }
    }
}
