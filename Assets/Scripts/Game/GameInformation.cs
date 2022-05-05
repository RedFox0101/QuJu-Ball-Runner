using System;
using UnityEngine.UI;
using UnityEngine;

public class GameInformation : MonoBehaviour
{
    public Text Life, BestScore, ScoreInfo, Coins;
    public static int Score;
    public static bool isScore = true;
    private void OnEnable()
    {
        EventHolder.LifeAction += LifeUpdateInfo;
        EventHolder.CoinAction += CoinUpdateInfo;
    }
    private void Start()
    {
        isScore = true;
        BestScore.text = Convert.ToString(PlayerPrefs.GetInt("BestScore"));
       

    }

    private void FixedUpdate()
    {
        if (isScore == true)
        {
            Score++;
        }
        ScoreInfo.text = Convert.ToString(Score);

    }


    private void CoinUpdateInfo(int value)
    {
        if (Coins)
        {
            Coins.text = "x" + Convert.ToString(value);
        }
    }
    private void LifeUpdateInfo(int value)
    {

        if (Life)
        {
            Life.text = "x" + Convert.ToString(value);
        }
    }

    private void OnDisable()
    {
        EventHolder.LifeAction += LifeUpdateInfo;
        EventHolder.CoinAction += CoinUpdateInfo;
    }
}
