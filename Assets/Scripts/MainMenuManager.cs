using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
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
        BestScoreMenu.text = "Best Score " + Convert.ToString(PlayerPrefs.GetInt("BestScore")); 
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
