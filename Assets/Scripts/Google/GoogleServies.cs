using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GoogleServies : MonoBehaviour
{
    private const string _leaderBorder = "CgkI9_K0wPEREAIQAA";

   

   public void EntranceToGooglePlay()
    {
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
    }
    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void ExitFromGPS()
    {
        PlayGamesPlatform.Instance.SignOut();
    }
}
